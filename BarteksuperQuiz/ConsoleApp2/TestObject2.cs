using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class TestObject2
    {
        public TestObject2()
        {
            //blueprint
            //domyślny konstruktor ktory jest pusty .To jest cenny fragment wiedzy :P
        }
        /// <summary>
        /// testowy komunikat
        /// </summary>
        /// <param name="x">podaj coś</param>
        /// <param name="y">podaj coś innego</param>
        /// <returns></returns>
        public string AddString(string x, string y)
        {
            return x + y;

        }

        public string SubString(string v1, int v2)
        {
            return v1.Substring(v2);
        }
    }
}
