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

        public static int _numberOfCars;
        private string _name;
        private string _modelname;
        public int _numberOfDoors;
        private int _engineCapacity;
        private double _averageFuelConsumption;
        public double fuelPrice;
        public double lenghtRoad;
        public double _cost;
        //properties
        public string Name { get { return _name; } }
        public string Modelname { get { return _modelname; } }

        public int NumberOfDoors { get { return _numberOfDoors; } }
        public int EngineCapacity { get { return _engineCapacity; } }
        public double AverageFuelConsumption { get; set; }


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


             double CalculateCost(double lenght, double fuelPrice)
            {
                return (AverageFuelConsumption * lenghtRoad / 100) * FuelPrice;


            }

        }

        private double CalculateFuel(double lenghtRoad)
        {
            return AverageFuelConsumption * lenghtRoad / 100;

        }



        //private double  FuelPrice(double FuelPrice, double lenghtRoad)
        //wypiszinfo


    }
}



