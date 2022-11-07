using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using car_try_console;

namespace car_try_console
{
    internal class Garage
    {
        //adres : adress
        //pojemnosc: capacity
        //liczba samoch: number_of_cars
        //samochody: cars_in


        private string _adress;
        private int _capacity;
        private int _number_of_cars = 0;
        private List<Car> _cars_in = new List<Car>();

        public string Adress { get { return _adress; } }
        public int Capacity
        {
            get { return _capacity; }
            set
            {
                _capacity = value;
                _cars_in = new List<Car>();

            }
        }
        public int Number_of_cars { get { return _number_of_cars; } set { _number_of_cars = value; } }
        // jak zrobić properkę do tablicy? 
        public List<Car> Cars_in { get { return _cars_in; } set { _cars_in = value; } }

        public Garage()
        {
            _adress = String.Empty;
            _capacity = 0;
            _number_of_cars = 0;
            _cars_in = new List<Car>();




        }


        public Garage(string adress, int capacity)

        {
            Console.WriteLine($"New garage created at {adress}, with {capacity} slots availeable");
            _cars_in = new List<Car>(capacity);
            _adress = adress;


        }

        public void ParkCar(Car car)
        {
            if (_cars_in.Count < _cars_in.Capacity)
            {
                _cars_in.Add(car);
                Console.WriteLine($"Car {car} has been parked succesfully");

            }
            else
                Console.WriteLine("Parking is full, try again later");
        }

        public Car? UnPark()

        {
            Car? to_return = null;
            if (_cars_in.Count == 0)
            {
                Console.WriteLine("Garage is empty");

            }
            else
            {
                to_return = _cars_in.Last();
                _cars_in.RemoveAt(Cars_in.Count - 1);
                Console.WriteLine("Car has been unparked :P");


            }
            return to_return;


        }
        public void WriteInfoGarage()

        {
            foreach (Car _ in _cars_in)
            {
                
                    // wszystkiego pola typu prostego klasy samochod


                //uzyj met wyszpisz info z CAR




            }







        }
        //properties PL:  właściwości dostępowe ^^





    }
}
