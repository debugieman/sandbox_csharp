using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_ovverride_practising_OOP
{


    public class Dog : Animal
    {
        public bool is_Happy { get; set; }
        public Dog(string name, int age) : base(name, age)
        {
            is_Happy = true;
        }

        public override void Eat()
        {
            base.Eat();
        }
        public override void MakeSound()
        {
            Console.WriteLine("Woof-Woof");
        }
        public override void  Play()
        {
            if (is_Happy)
            {
                base.Play();
            }
            else
            {
                Console.WriteLine("I'm sad , I dont wanna play!");
            }
        }



    }

}