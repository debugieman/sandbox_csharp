
using car_try_console;
using static car_try_console.Garage;




var auto1 = new Car("Toyota", "Avensis", 4, 3, 2.2);
var auto2 = new Car("Bartekmobile", "SuperCustomMade", 2, 3, 10.1);
var auto3 = new Car("Porsche", "Carrera", 5, 5, 15.0);

auto1.WriteInfo();
Console.WriteLine($"|Total fulel cost will be : {auto1.CalculateCost(100, 9)}");
auto2.WriteInfo();
auto3.WriteInfo();


Console.WriteLine(Car._numberOfCars);


Console.ReadKey();
