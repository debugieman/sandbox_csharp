using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Phonenumber_list
{
    internal class Contacts
    {
        public string name;
        public int number;

        public string Name { get; set; }
        public int Number { get; set; }

        Dictionary <int , string> Contact_lsit = new Dictionary<int , string >();

        public void Add_Contact(string Name, int Number)

        {
            this.name = Name;
            this.number = Number;   
            Contact_lsit.Add(Number, Name);

        }

        public void (int number)







    }
}
