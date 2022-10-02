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
            //UC-4 Ability to Delete a person using persons name
            Console.WriteLine("Welcome to my Address Book");


            int choice = 0;
            while (choice != 2)
            {
                Console.WriteLine("1.To get Furthur choices \n2.To exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if(choice!=2)
                    AddressBook.AddPerson();
            }
            AddressBook.ListPeople();
            Console.WriteLine("You are out of the Address Book!....");
            Console.ReadLine();

        }
    }
}
