# generovanimapy
Matěj Franců, Erik Hrazdira - zápočtová práce

Zvolíte rozměr čtverce generovaného pole, minimum je 2, maximum je 20, a kliknete na tlačítko, poté se vygeneruje mapa.

![fsadfsfdascvsavsb](https://user-images.githubusercontent.com/92072825/211858086-8d6e7ed8-319c-4e3f-9ddb-dad843d7a1cd.png)

Dlaždic, z kterých program vybírá, je 10. Začína od přostředka kde náhodně vygeneruje první dlaždici a pokračuje viz obrázek.
![Bez názvu](https://user-images.githubusercontent.com/92072825/211861496-b506c0c4-cdd8-4d5a-8b12-cda5f478c5ab.png)

Při pokládání dlaždice volá metodu generate, která zkontroluje všechny dlaždice okolo, najde všechny dlaždice co tam můžou být umístěny a náhodně z nich jednu vybere.

Pokud nenajde žádnou vhodnou dlaždici vrací hodnotu -1 a generovaní mapy jde celé od znova.

Pokud se znova klikne na tlačítko, mapa se smaže a vygeneruje nová.
