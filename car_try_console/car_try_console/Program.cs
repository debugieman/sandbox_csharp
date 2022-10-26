
using car_try_console;

/*
static string[] ReadFile(string filename)
{
    string[] files = System.IO.File.ReadAllLines(filename);
    return lines;
}

*/


var auto1 = new Car("Toyota", "Avensis", 4, 3, 2.2);
var auto2 = new Car("Bartekmobile", "SuperCustomMade", 2, 3, 10.1);
var auto3 = new Car("Porsche", "Carrera", 5, 5, 15.0);

auto1.WriteInfo();
Console.WriteLine($"|Total fulel cost will be : {auto1.CalculateCost(100, 9)}");
auto2.WriteInfo();
auto3.WriteInfo();
//Console.WriteLine($"Our Magnificent factory created new {auto1.Name}, {auto1.Modelname}");
//Console.WriteLine($"Our Magnificent factory created new {auto2.Name}, {auto2.Modelname} ");
//Console.WriteLine($"Our Magnificent factory created new {auto3.Name}, {auto3.Modelname} ");


Console.WriteLine(Car._numberOfCars);


Console.ReadKey();
