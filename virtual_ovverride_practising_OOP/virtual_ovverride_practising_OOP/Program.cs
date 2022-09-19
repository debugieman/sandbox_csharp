// See https://aka.ms/new-console-template for more information
using virtual_ovverride_practising_OOP;

Console.WriteLine("OOP c.d. Learning passing the arguments form class to class. Inheritance practising!");

Dog dog = new Dog("Burek", 8);
Console.WriteLine($"Dog {dog.Name} is {dog.Age} year old wich is {dog.Age * 10} in human years ");
dog.Play();
dog.Eat();

Console.WriteLine("I be happy if it prints ");


Console.ReadKey();