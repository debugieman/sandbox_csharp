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
        
        private static int _numberOfCars = 0;
        private string _name { get; set; }
        private string _modelname { get; set; }
        private int _numberOfDoors { get; }
        private int _engineCapacity { get; }
        private double _averageFuelConsumption { get; }
        

        //properties

        
        public string Name {get { return _name; }}
        public string Modelname { get { return _modelname; } }

        public string NumberOfDoors { get { return _numberOfDoors; } }
        public int EngineCapacity { get { return _engineCapacity; } }
        public double AverageFuelConsumption { get { return _averageFuelConsumption; } }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">This is name of the car's brand.Name of manufacturer(for example Toyota)</param>
        /// <param name="modelname">This is model of certain brand's car (for example Avensis) </param>
        /// <param name="numberOfDoors">It's number of doors with windowpane, that you can access a car with(it's usually number between 2 and 5)</param>
        /// <param name="enginecapacity">is calculated by multiplying together three values; the distance travelled by the piston (the stroke length), the circular area of the cylinder, and the number of cylinders in the whole engine(usually between 1.0 and 6.0)</param>
        /// <param name="averageFuelConsumption">Fuel consumption measures the amount of fuel a car consumes to go a specific distance(In this example, its liters per 100km)</param>
        public Car(string name, string modelname, int numberOfDoors, int enginecapacity, double averageFuelConsumption)
        {

        }
        
     
      
        public void FuelPrice(int engineCapacity, int lenght)
        {

            int price = (engineCapacity * lenght) * 3;
            Console.WriteLine(price);


        }
        //private methods

    }
}
