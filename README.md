# Beléptetőprogram
Ez a **Vidéki-IT** beléptető-programja, készítette *Nagy Sándor Márk* és *Tóth Álmos*.

Ez a program egy beléptető rendszer, amiben feljegyezhet minden érkező járművet, vagy személyt, és pontos érkezési idejét.

A program az *Vidéki-IT* fő mappán belül az *belepteto_rendszer* mappában található. 

---

## Adatbazis

A program indításkor készít egy adatbazis.txt fájl-t, amiben tárolni fogja az összes bevitt adatot. Az adatbázis fálj helye:
*..\Videki-IT\belepteto_rendszer\belepteto_rendszer\bin\Debug\net10.0*

## Alap menüpontok

Amikor megnyitja a programot, 3 opció közül választhat, Adatbevitel, Adatbázis megtekintése, és Leállítás. A menükben számok beírásával lehet navigálni, egy menüpont melletti zárójelben lévő szám beírásával.

- ### Adatbevitel (0. menüpont)

Ha az adatbevitel menüpontot választja, ki kell választania hogy *járművet*, vagy *személyt* szeretne bevinni a programba. Ezután meg kell adni az új személy/jármű adatait a paramétereknek megfelelően, semmilyen mezőt nem hagyhat üresen. Nem mindegy hogy mit írsz egy egy paraméterhez, ezért itt egy puska:
A jármű paraméterei:
    - Rendszám: itt szöveget kér be, ezt nehéz elrontani
    - Típusát: itt szöveget kér be, ezt nehéz elrontani
    - Súly (kg): egész számot kér be
    - Márka: itt szöveget kér be, ezt nehéz elrontani
    - Szín: itt szöveget kér be, ezt nehéz elrontani

A személy paraméterei:
    - Név: itt szöveget kér be, ezt nehéz elrontani
    - Nem: itt szöveget kér be, ezt nehéz elrontani
    - Kor: itt egész számot kér be
    - Személyi igazolvány szám: itt egész számot kér be

- ### Adatbázis megtekintése (1. menüpont)

Az adatbázis megtekintése megmutatja a felhasználónak a teljes adatbázis tartalmát, úgy ahogyan a fájlban kinéz. Ez hasznos akkor, ha a keresés funkcióval nem találja, amit keres.

- ### Keresés (2. menüpont)

A keresés funkcióval megkeresheti az egyes elemeket az adatbázisban. Több jellemző alapján is lehet keresni, ha hasonló 

- ### Leállítás (3. menüpont)

Leállítja a programot.