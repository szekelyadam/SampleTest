# SampleTest
These are my solutions for a sample C# test. This test is provided by the Óbuda University to prepare for the first test. 

The name and parameter list of the methods are in hungarian, because in the test they were written in hungarian, but the codes written by myself are in english.

The tasks(in hungarian) are the following:

```C#
int[,] TombVeletlenGeneral(int hetekSzama)
``` 
Előállít egy megfelelő méretű kétdimenziós tömböt, melyet feltölt véletlen adatokkal.
A feltöltésnél vegyük figyelembe az alábbi szabályokat:
* Minden héten legyen két olyan nap, amikor nem edz a futó. Azt nem tudjuk előre,
hogy melyek ezek a napok.
* A hétköznapi edzéseken 3 és 10 kilométer közötti távokat teljesít.
* A hétvégi edzéseken 8 és 30 kilométer közötti távokat fut.


```C#
string TombKiir(int[,] lefutottTavok)
```
A bemeneti tömb adataiból készített stringet ad vissza, melyben az egyes hetek futási
adatai egymástól vesszővel vannak elválasztva, a hetek között pedig sörtörés van.

```C# 
void TombModosit(int hetIndex, int napIndex, int[,] lefutottTavok)
```
Az adott heti és adott napi edzés távját lehet módosítani a metódus segítségével.

```C# 
int OsszesKilometer(int[,] lefutottTavok)
```
Megadja, hogy a futó összesen hány kilométert futott le.

```C#
int HosszuFutasokSzama(int[,] lefutottTavok)
```
Megadja, hogy a futó hány alkalommal edzett 15 kilométernél hosszabb távon.

```C#
int[] HetiOsszesites(int[,] lefutottTavok)
```
Egy tömbben visszaadja az egyes hetek összesített kilométer adatait.

```C#
bool NovekszikE(int[] hetiTavok)
```
Eldönti, hogy a hetente lefutott távok folyamatosan növekednek-e.

```C#
int[] CsokkenobeRendeze(int[] hetiTavok)
```
A bemeneti tömb elemeit csökkenő sorrendben adja vissza. A bemeneti tömb közben
ne változzon meg!

A Main() függvényböl tesztelje mindegyik elkészített metódus működését!
