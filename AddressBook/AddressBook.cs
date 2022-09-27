using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        public static List<Contacts> People = new List<Contacts>();

        public static void AddPerson()
        {
            Contacts contacts = new Contacts();

            Console.WriteLine("Enter First Name:");
            contacts.First_name = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            contacts.Last_name = Console.ReadLine();
            Console.WriteLine("Enter Address:");
            contacts.Address = Console.ReadLine();
            Console.WriteLine("Enter State:");
            contacts.State = Console.ReadLine();
            Console.WriteLine("Enter City:");
            contacts.City = Console.ReadLine();
            Console.WriteLine("Enter Zip:");
            contacts.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number:");
            contacts.Phone_number = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email:");
            contacts.Email = Console.ReadLine();

            People.Add(contacts);
        }

        private static void PrintPerson(Contacts person)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("First Name: " + person.First_name);
            Console.WriteLine("Last Name: " + person.Last_name);
            Console.WriteLine("Address: " + person.Address);
            Console.WriteLine("State: " + person.State);
            Console.WriteLine("City: " + person.City);
            Console.WriteLine("Zip: " + person.Zip);
            Console.WriteLine("Phone Number: " + person.Phone_number);
            Console.WriteLine("Email: " + person.Email);
            Console.WriteLine("-------------------------------------------");
        }
        public static void ListPeople()
        {
            foreach (var contacts in People)
            {
                PrintPerson(contacts);
            }
        }
    }
}
