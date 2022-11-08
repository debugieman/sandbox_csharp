
using car_try_console;
using static car_try_console.Garage;




var auto1 = new Car("Toyota", "Avensis", 4, 3, 2.2);
var auto2 = new Car("Bartekmobile", "SuperCustomMade", 2, 3, 10.1);
var auto3 = new Car("Porsche", "Carrera", 5, 5, 15.0);

auto1.WriteInfo();
Console.WriteLine($"|Total fulel cost will be : {auto1.CalculateCost(100, 9)}");
auto2.WriteInfo();
auto3.WriteInfo();
var g1 = new Garage("Mickiewicza", 15);
var g2 = new Garage("Słowackiego", 5);
var g3 = new Garage("Kolejowa", 8);

g1.ParkCar(auto1);
g2.ParkCar(auto2);
g3.ParkCar(auto3);
g3.UnPark();
g3.UnPark();



Console.WriteLine(Car._numberOfCars);
g1.WriteInfoGarage();



Console.ReadKey();
