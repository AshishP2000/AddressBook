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
            int choice1 = 0;
            Console.WriteLine("Enter what Operation you Want to do: ");
            Console.WriteLine("1.Add Person\n2.Edit Person Info\n3.Remove Person Info");
            choice1 = Convert.ToInt32(Console.ReadLine());

            switch (choice1)
            {
                case 1:
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
                    break;

                case 2:
                    string name;
                    int choice = 0;
                    Console.WriteLine("Enter Name you want to edit: ");
                    name = Console.ReadLine();
                    for (int i = 0; i < People.Count; i++)
                    {
                        Contacts contact = People[i];
                        //PrintPerson(contact);

                        if (contact.First_name == name)
                        {
                            Console.WriteLine("1.First Name\n2.Last Name\n3.Address\n4.State\n5.City\n6.Zip\n7.Phone Number\n8.Email");
                            Console.WriteLine("Choose what you want to edit");
                            choice = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Choose what you want to edit");
                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("Enter First Name:");
                                    contact.First_name = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter Last Name:");
                                    contact.Last_name = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter Address:");
                                    contact.Address = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter State:");
                                    contact.State = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter City:");
                                    contact.City = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter Zip:");
                                    contact.Zip = Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 7:
                                    Console.WriteLine("Enter Phone Number:");
                                    contact.Phone_number = Convert.ToInt64(Console.ReadLine());
                                    break;
                                case 8:
                                    Console.WriteLine("Enter Email:");
                                    contact.Email = Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("Enter Valid Number");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("There is nothing to Edit");
                        }
                    }
                    break;
            }
            
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
