/*Cwiczenia - zmienne:

tam gdzie jest to mozliwe uzywaj typu dynamicznego var

# zadeklaruj zmienna awesomeNumber ktora bedzie przechowywala liczbe

# zadeklaruj zmienna awesomeNumber ktora bedzie przechowywala liczbe, zainicjalizuj ja wartoscia 5

# zadeklaruj zmienna numbersArray ktora bedzie przechowywala tablice liczb

# zadeklaruj zmienna numbersArray ktora bedzie przechowywala tablice pieciu liczb, zainicjalizuj tablice

# zadeklaruj zmienna numbersArray ktora bedzie przechowywala tablice pieciu liczb, zainicjalizuj tablice 
podajac piec liczb ktore do niej przypiszemy
*
*/

//var awesomeNumber = 5;
//int[] numbersArray = new int[5] { 1, 2, 3, 4, 5 };
string[] Overwatch = new string[4] { "Gr3chu", "Tabax", "no1ife", "Cocained" };
//sort throu using for loop
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("std[{0}] = {1}", i, Overwatch[i]);
}



//sort throu using foreach loop
foreach (string s  in Overwatch)
{
    Console.WriteLine(s);
}


string[,] OverwatchPros =  {{ "Gr3chuPro", "TabaxPro", "no1ifePro", "CocainedPro" },
                             {"player0", "player1", "player2", "player3" },
                              };

for(int g = 0; g < OverwatchPros.GetLength(0); g++)
{
    for (int j = 0; j < OverwatchPros.GetLength(1); j++) 
{
    Console.Write(OverwatchPros[g,j] + ", ");
}



}

Console.WriteLine($"The very first player is: {OverwatchPros[0,0]}");





string[,,] Overwatch2Pros =  {
                             { "Gr3chuPro", "TabaxPro", "no1ifePro", "CocainedPro" },
                             {"player0", "player1", "player2", "player3" },
                              {"Hog", "Merci", "Rein", "Zarya" }



};

for (int g = 0; g < Overwatch2Pros.GetLength(0); g++)
{
    for (int j = 0; j < Overwatch2Pros.GetLength(1); j++)
    {
        Console.Write(Overwatch2Pros[g, j] + ", ");
    }



}

Console.WriteLine($"The very first player is: {OverwatchPros[0, 0]}");

/*
# zadeklaruj zmienna twoDimensionalArray, ktora bedzie dwu-wymiarowa tablica typu string i zainicjalizuj ja. 
Wymiary tablicy to 3 i 5

# zainicjalizuj zmienna result, ktora bedzie przechowywala wynik odejmowania dwoch liczb 5 i 10

# utworz zmienna typu string o nazwie stringResult, do ktorej przypiszesz wartosc result z cwiczenia wyzej



Cwiczenia - metody:


# zadeklaruj metode o nazwie Test, nie zwracajaca nic oraz nie przyjmujaca zadnych argumentow

# zaimplementuj prywatna metode o nazwie Test, nie zwracajaca nic oraz nie przyjmujaca zadnych argumentow

# zaimplementuj publiczna metode o typie zwarcanym int i nazwie Add, ktora przyjmuje dwa argumenty int x i int y

# zaimplementuj prywatna metode o typie zwracanym string i nazwie Add, ktora przyjmuje dwa argumenty string x i string y

# zaimplementuj prawytna metode o nazwie Add ktora jest typu void, ktora przyjmuje trzy argumenty: x,y, result
X,Y powinny byc intami.
result powinnien byc oznaczony jako argument zwracajacy wartosc metody 'out'

# cwiczenie wykonaj dla wszystkich typow prostych

Zadeklaruj zmienna danego typu i zainicjalizuj ja dowolna wartoscia.
W nastepnych liniach dokonaj zmiany typu na kazdy z mozliwych typow prostych dokonujac rzutowania.

przyklad:

var x = 1;

//string
//bool
//float
//double
//bit
//char
*/