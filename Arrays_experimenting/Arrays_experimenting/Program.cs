string[,] Cars = { 
                   {"Bugatti", "Mercedes", "Porche", "Ferrari", "Cadilac" }, 
                   {"Wolksvagen", "Nyska", "Mazda", "GrandCherokee", "Lincon" }, 
};

Console.WriteLine(Cars[0,1]);


foreach (string car in Cars)
{
    Console.WriteLine($"The brand of {car} cars is raising in value");
};

for (int i = 0; i < Cars.GetLength(0); i++)
{
    for (int j = 0; j < Cars.GetLength(1); j++)
    {
        
        Console.WriteLine(Cars[i, j]);
    }
};

Console.ReadKey();
 