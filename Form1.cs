using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hfgfxx
{
    public partial class Form1 : Form
    {
        int r = 10;
        PictureBox[,] map;
        Random random = new Random();
        int[,] pieces = { { 1, 1, 1, 1 }, { 0, 1, 0, 0 }, { 1, 1, 0, 0 }, { 1, 0, 0, 1 }, { 0, 0, 1, 1 }, { 0, 1, 1, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 }, { 1, 0, 0, 0 }, { 0, 0, 0, 0 }, { 2, 2, 2, 2 } };
        int klik = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void tl_generovat_Click(object sender, EventArgs e)
        {
            r = (int)rozmer.Value;
            if (klik != 0)
            {
                foreach (PictureBox vec in map) Controls.Remove(vec);
            }
            map = new PictureBox[r, r];
            Bitmap[,] mappic = new Bitmap[r, r];
            int[,] index = new int[r, r];
            int x, y;
            Boolean check = false;
            while (check == false)
            {
                Boolean check1 = true;
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < r; j++)
                    {
                        index[i, j] = 10;
                    }
                }
                if (r % 2 != 0)
                {
                    x = r / 2;
                    y = r / 2;
                    index[x, y] = random.Next(10);
                    x--;
                    y--;
                }
                else
                {
                    x = (r / 2) - 1;
                    y = (r / 2) - 1;
                }
                while (x >= 0 && y >= 0 && check1 == true)
                {
                    index[x, y] = random.Next(10);
                    int pomx = x;
                    int pomy = y;
                    for (int i = pomy + 1; i < r - pomy; i++)
                    {
                        index[x, i] = generate(index, x, i, r);
                        if(index[x, i] == -1)
                        {
                            check1 = false;
                            break;
                        }
                        y++;
                    }
                    for (int i = pomx + 1; i < r - pomx; i++)
                    {
                        index[i, y] = generate(index, i, y, r);
                        if (index[i, y] == -1)
                        {
                            check1 = false;
                            break;
                        }
                        x++;
                    }
                    pomy = y;
                    for (int i = pomy - 1; i >= r - pomy - 1; i--)
                    {
                        index[x, i] = generate(index, x, i, r);
                        if (index[x, i] == -1)
                        {
                            check1 = false;
                            break;
                        }
                        y--;
                    }
                    pomx = x;
                    for (int i = pomx - 1; i >= r - pomx; i--)
                    {
                        index[i, y] = generate(index, i, y, r);
                        if (index[i, y] == -1)
                        {
                            check1 = false;
                            break;
                        }
                        x--;
                    }
                    x--;
                    x--;
                    y--;
                }
                if (check1 != false)
                {
                    check = true;
                }
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    mappic[i, j] = new Bitmap(Application.StartupPath + "/ikony/" + Convert.ToString(index[i, j]) + ".png");
                    map[i, j] = new PictureBox();
                    map[i, j].Parent = this;
                    map[i, j].BorderStyle = BorderStyle.None;
                    map[i, j].Left = j * (mappic[i, j].Width);
                    map[i, j].Top = i * (mappic[i, j].Height);
                    map[i, j].Width = mappic[i, j].Width;
                    map[i, j].Height = mappic[i, j].Height;
                    map[i, j].Image = mappic[i, j];
                }
            }
            tl_generovat.Location = new Point(r * mappic[0, 0].Width, 12);
            rozmer.Location = new Point(r * mappic[0, 0].Width, 41);
            klik++;
        }
        public int generate(int[,] index, int x, int y, int r)
        {
            int[] pom = new int[4];
            int[] pom1 = new int[10];
            if (x-1 >= 0)
            {
                pom[0] = index[x-1, y];
            } 
            else pom[0] = 10;
            if (x+1 < r)
            {
                pom[2] = index[x+1, y];
            }
            else pom[2] = 10;
            if (y-1 >= 0)
            {
                pom[3] = index[x, y-1];
            }
            else pom[3] = 10;
            if (y+1 < r)
            {
                pom[1] = index[x, y+1];
            }
            else pom[1] = 10;
            int poc = 0;
            for (int i = 0; i < 10; i++)
            {
                if((pieces[pom[0],2] == pieces[i,0] || pom[0] == 10) && (pieces[pom[1], 3] == pieces[i, 1] || pom[1] == 10) && (pieces[pom[2], 0] == pieces[i, 2] || pom[2] == 10) && (pieces[pom[3], 1] == pieces[i, 3] || pom[3] == 10))
                {
                    pom1[i] = 1;
                    poc++;
                }
            }
            int[] pom2 = new int[poc];
            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                if (pom1[i] == 1)
                {
                    pom2[j] = i;
                    j++;
                }
            }
            if(poc == 0)
            {
                return -1;
            }
            return pom2[random.Next(poc)];
        }
    }
}
