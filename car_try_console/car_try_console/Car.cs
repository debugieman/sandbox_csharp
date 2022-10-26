using car_try_console;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        #region fields and constants
        public static int _numberOfCars;
        private string _name;
        private string _modelname;
        public int _numberOfDoors;
        private int _engineCapacity;
        private double _averageFuelConsumption;
        public double fuelPrice;
        public double lenghtRoad;
        public double _cost;
        #endregion
        //properties
        public string Name { get { return _name; } }
        public string Modelname { get { return _modelname; } }

        public int NumberOfDoors { get { return _numberOfDoors; } set { _numberOfDoors = value; } }
        public int EngineCapacity { get { return _engineCapacity; } }
        public double AverageFuelConsumption { get { return _averageFuelConsumption; } }


        public double FuelPrice { get; set; }

        public double Cost
        {
            get { return _averageFuelConsumption * fuelPrice; }



        }




        public Car(string name,
                          string modelname,
                          int numberOfDoors,
                          int enginecapacity,
                          double averageFuelConsumption)
        {

            _numberOfCars++;
            _name = name;
            _modelname = modelname;
            _numberOfDoors = numberOfDoors;
            _engineCapacity = enginecapacity;
            _averageFuelConsumption = averageFuelConsumption;


             

        }
        
        private double CalculateFuelConsumption(double lenghtRoad)
        {
            return AverageFuelConsumption * lenghtRoad / 100;

        }

        public double CalculateCost(double lenght, double fuelPrice)
        {
            return CalculateFuelConsumption(lenght) * fuelPrice;


        }

        public void WriteInfo()
        {
            Console.WriteLine($"Name: {Name}");
        // dopisz
        
        
        
        }

        public static void WriteNumberOfCars()
        {
            Console.WriteLine(_numberOfCars);
        
        }


    }
}



