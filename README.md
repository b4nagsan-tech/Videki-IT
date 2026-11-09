# Beléptetőprogram

Ez a **Vidéki-IT** beléptető-programja, készítette *Nagy Sándor Márk* és *Tóth Álmos*.

Ez a program egy beléptető rendszer, amiben feljegyezhet minden érkező járművet, vagy személyt, és pontos érkezési idejét.
A futtatható program a *Vidéki-IT* fő mappán belül a *belepteto_rendszer* mappában található úgyszintén *belepteto_rendszer* néven. 


## Adatbázis

A program indításkor készít egy adatbazis.txt fájl-t, amiben tárolni fogja az összes bevitt adatot. Az adatbázis fálj helye:
*..\Videki-IT\belepteto_rendszer\belepteto_rendszer\bin\Debug\net10.0*

## Alap menüpontok

Amikor megnyitja a programot, egy menüt fog látni, 3 opció közül választhat, Adatbevitel, Adatbázis megtekintése, Keresés, és Leállítás. A menükben számok beírásával lehet navigálni, egy menüpont melletti zárójelben lévő szám beírásával.

- ### Adatbevitel (0. menüpont)

Ha az adatbevitel menüpontot választja, ki kell választania hogy *járművet*, vagy *személyt* szeretne bevinni a programba. Ezután meg kell adni az új személy/jármű adatait a paramétereknek megfelelően, és semmilyen mezőt nem hagyhat üresen! Nem mindegy hogy mit ír be a paraméterekhez, ezért itt egy puska:

- **Egy jármű paraméterei:**
    - Rendszám:     szöveget kér be, de számokat is írhat
    - Típus:        szöveget kér be
    - Súly (kg):    egész számot kér be
    - Márka:        itt szöveget kér be
    - Szín:         szöveget kér be

- **Egy személy paraméterei:**
    - Név:          szöveget kér be
    - Nem:          szöveget kér be
    - Kor:          egész számot kér be
    - Személyi igazolvány szám: egész számot kér be

Amint beírta az összes paramétert, a program automatikusan lementi az *adatbazis-txt*-be.

- ### Adatbázis megtekintése (1. menüpont)

Az adatbázis megtekintése megmutatja a felhasználónak a teljes adatbázis tartalmát, úgy ahogyan a fájlban kinéz. Ez hasznos akkor, ha a keresés funkcióval nem találja, amit keres.

- ### Keresés (2. menüpont)

A keresés funkcióval megkeresheti az egyes elemeket az adatbázisban. A program keresésnél az egész fájl-t átnézi, és ha talál megegyezést, akkor az egész sort kiírja, amiben az egyezést találja. Bármilyen jellemző alapján lehet keresni. Ha több találat van a keresett szóra, akkor az összes találatot kiírja.

- ### Leállítás (3. menüpont)

Ez a menüpont választása istant leállítja a loop-ot, azaz kidob a főmenüből, de a programot még manuálisan kell bezárni.
