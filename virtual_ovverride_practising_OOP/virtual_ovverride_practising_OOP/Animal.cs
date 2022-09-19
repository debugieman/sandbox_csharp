using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_ovverride_practising_OOP
{
    public class Animal
    {
        // CHallange  make class that :
        //name age is_hungry constructor make_sound(), eat(), play()  
        //then we pass the args to other class. 
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Is_Hungry { get; set; }
        public bool Is_Happy { get; set; }


        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Is_Hungry = true;
            this.Is_Happy = true;

        }
        
        

        public virtual void MakeSound()
        {

        }
        public virtual void Eat()
        {
            if (Is_Hungry)
                Console.WriteLine($"{Name} is eating");
            else
            {
                Console.WriteLine($"{Name} is not hungry");
            }

        }
        public virtual void  Play()
        {
            Console.WriteLine($"{Name} is playing");
        }

    }
}
