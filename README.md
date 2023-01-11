# generovanimapy
Matěj Franců, Erik Hrazdira - zápočtová práce

Zvolíte rozměr čtverce generovaného pole, minimum je 2 maximum je 20, a kliknete na tlačítko, poté se vygeneruje mapa.

Dlaždic je 10, začína od přostředka kde náhodně vygeneruje první dlaždici a pokračuje viz obrázek.
![Bez názvu](https://user-images.githubusercontent.com/92072825/211854948-88816465-4833-49ea-a840-81333a9698bd.png)

Při pokládání dlaždice volá metodu generate, která zkontroluje všechny dlaždice okolo, najde všechny dlaždice co tam můžou být umístěny a náhodně z nich jednu vybere.

Pokud nenajde žádnou vhodnou dlaždici vrací hodnotu -1 a generovaní mapy jde celé od znova.

Pokud se znova klikne na tlačítko, mapa se smaže a vygeneruje nová.
