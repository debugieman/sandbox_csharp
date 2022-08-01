using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace car_try_console
{
    public class Car
    {
        //const and fields
        //private static int counter = 0; 
        public static int count = 0;
        private string name;
        private string model;
        private int numberOfDoors;
        private int engineCapacity;
        private int averageFuelConsumption;

        //properties

        //private static int Counter
        //{
        //   return  CounterOfObjects++
        //}
        public string Name
        {
            get { return name; }

        }
        private string numberOfDoors;

        public string NumberOfDoors
        {
            get { return numberOfDoors; }
            
        }

        public string Model { get; set; }
        public int NumberOfDoors { get; set; }
        public int EngineCapacity { get; set; }
        public int AverageFuelConsumption { get; set; }
        //constructor
        public Car()
        {
            return count++;
        }
        
        //public methods
        public Car(string name, ...)
        { 
        this.name = name;
        
        }
        public void FuelPrice(int engineCapacity, int lenght)
        {

            int price = (engineCapacity * lenght) * 3;
            Console.WriteLine(price);


        }
        //private methods

    }
}
