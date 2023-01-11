namespace hfgfxx
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tl_generovat = new System.Windows.Forms.Button();
            this.rozmer = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.rozmer)).BeginInit();
            this.SuspendLayout();
            // 
            // tl_generovat
            // 
            this.tl_generovat.Location = new System.Drawing.Point(12, 12);
            this.tl_generovat.Name = "tl_generovat";
            this.tl_generovat.Size = new System.Drawing.Size(110, 23);
            this.tl_generovat.TabIndex = 0;
            this.tl_generovat.Text = "Generovat";
            this.tl_generovat.UseVisualStyleBackColor = true;
            this.tl_generovat.Click += new System.EventHandler(this.tl_generovat_Click);
            // 
            // rozmer
            // 
            this.rozmer.Location = new System.Drawing.Point(12, 41);
            this.rozmer.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.rozmer.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rozmer.Name = "rozmer";
            this.rozmer.Size = new System.Drawing.Size(110, 22);
            this.rozmer.TabIndex = 1;
            this.rozmer.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.rozmer);
            this.Controls.Add(this.tl_generovat);
            this.Name = "Form1";
            this.Text = "Generování mapy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.rozmer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tl_generovat;
        private System.Windows.Forms.NumericUpDown rozmer;
    }
}

