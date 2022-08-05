
using car_try_console;

/*
static string[] ReadFile(string filename)
{
    string[] files = System.IO.File.ReadAllLines(filename);
    return lines;
}

*/


var autoWiktora = new Car("Toyota", "Avensis", 4, 3, 2.2);
var autoBartka = new Car("Bartekmobile", "SuperCustomMade", 2, 3, 10.1);
var autoPatryka = new Car("Porsche", "Carrera", 5, 5, 15.0);


Console.WriteLine($"Our Magnificent factory created new {autoWiktora.Name}, {autoWiktora.Modelname} ");
Console.WriteLine($"Our Magnificent factory created new {autoBartka.Name}, {autoBartka.Modelname} ");
Console.WriteLine($"Our Magnificent factory created new {autoPatryka.Name}, {autoPatryka.Modelname} ");


Console.WriteLine(Car._numberOfCars);


Console.ReadKey();
