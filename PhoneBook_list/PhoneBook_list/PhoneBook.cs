using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook_list
{
    internal class PhoneBook
    {
        public List<Contact> Contacts { get; set; }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);

        }

        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
                Console.WriteLine("Contact using this number was not found");
            else
            {
                Console.WriteLine($"Contact found. /nContact: {contact.Name} is using the number {contact.Number}");
            }



        }

        public void DisplayContacts()
        {
            foreach (var contact in Contacts)
            {
                Console.WriteLine($"Contact: {contact.Name} number:{contact.Number}");
            }


        }

        public void Seach_by_name(string searchName)
        { 
        var matching_contact = Contacts.Where(x => x.Name.Contains(searchName)).ToList();
            foreach (var contact in matching_contact)
            {
                Console.WriteLine($"Contact: {contact.Name} number:{contact.Number}");

            }
        
        
        }
    }       
}
