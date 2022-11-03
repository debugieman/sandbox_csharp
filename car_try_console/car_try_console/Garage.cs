using System;
using System.Collections.Generic;
using System.Linq;
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
        private string[] _cars_in = new string[0];

        public string Adress { get { return _adress; } }
        public int Capacity
        {
            set
            {
                Capacity = value;
                Cars_in = new cars_in[];

            }
        }
        public int Number_of_cars { get { return _number_of_cars; } set { _number_of_cars = value; } }
        // jak zrobić properkę do tablicy? 
        public string[] Cars_in { get { return _number_of_cars; } set { _number_of_cars = value; } }




        //properties PL:  właściwości dostępowe ^^





    }
}
