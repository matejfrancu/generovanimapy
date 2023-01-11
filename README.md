# generovanimapy
Matěj Franců, Erik Hrazdira - zápočtová práce
Zvolíte rozměr čtverce generovaného pole, minimum je 2 maximum je 20, a kliknete na tlačítko, poté se vygeneruje mapa.
Dlaždic je 10, začína od přostředka kde náhodně vygeneruje první dlaždici a pokračuje viz obrázek.
![Bez názvu](https://user-images.githubusercontent.com/92072825/211851650-1c5b56b7-a6ca-47c0-a7f9-a95c3342a5fe.png)

Při pokládání dlaždice volá metodu generate, která zkontroluje všechny dlaždice okolo, najde všechny dlaždice co tam můžou být umístěny a náhodně z nich jednu vybere.
Pokud nenajde žádnou vhodnou dlaždici vrací hodnotu -1 a generovaní mapy jde celé od znova.
Pokud se znova klikne na tlačítko, mapa se smaže a vygeneruje nová.
