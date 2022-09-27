using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC-2 Ability to add a new contact to Address Book
            Console.WriteLine("Welcome to my Address Book");

            AddressBook.AddPerson();
            
            AddressBook.ListPeople();

            Console.ReadLine();

        }
    }
}
