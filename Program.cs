using PhonebookApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;


//Zadanie:

//Utwórz aplikację konsolową która imituję zachowanie aplikacji z kontaktami na telefonie.

//Kontakt to: nazwa i numer telefonu.

//Aplikacja powinna:

//Dodawać kontakty

//Wyświetlić kontakt na podstawie numeru

//Wyświetlić wszystkie kontakty

//Wyszukać kontakty dla danej nazwy

namespace Program;
partial class Program
{
    static void Main(string[] args)
    { 
 
        var phoneBook = new PhoneBook();
        
        string input = "9";
        do
        {
            Console.WriteLine("Choose one option");
            Console.WriteLine("1. Add Contact\n2. Check Number\n3. Show All Contacts\n4. Search For Name\n5. Remove Contact By Number\n0. Close Application");
            input = Console.ReadLine();

            if (input == "1")
            {
                string name;
                string phoneNumber;
                Console.WriteLine("What Name would you like to give it?");
                
                while (true)
                {
                    var inputName = Console.ReadLine();
                    if (inputName.Length < 3)
                    {
                        Console.WriteLine("The name has to contain at least 3 letters");
                    }
                    else
                    {
                        name = inputName;
                        break;
                    }
                }
                Console.WriteLine("What Number should it contain?");
                
                while (true)
                {
                    var inputPhoneNumber = Console.ReadLine();
                    if (inputPhoneNumber.Length < 9)
                    {
                        Console.WriteLine("The number has to contain at least 9 letters");
                    }
                    else
                    {
                        phoneNumber = inputPhoneNumber;
                        break;
                    }
                }

                var newContact = new Contact(name, phoneNumber);
                phoneBook.AddContact(newContact);


            }
            else if (input == "2")
            {
                Console.WriteLine("What number would you like to check?\n");
                var numberToCheck = Console.ReadLine();

                Console.WriteLine($"This number belongs to: \n");
                phoneBook.DisplayContact(numberToCheck);
            }
            else if (input == "3")
            {
                Console.WriteLine("Showing all contacts:\n");
                phoneBook.ShowAllContacts();
            }
            else if (input == "4")
            {
                Console.WriteLine("Which persons number would you like to know?\n");
                string nameToCheck = Console.ReadLine();
                phoneBook.SearchName(nameToCheck);
            }
            else if(input == "5")
            {
                Console.WriteLine("What number would you like to remove?\n");
                var numberToRemove = Console.ReadLine();
                phoneBook.RemoveContactByNumber(numberToRemove);
            }
            else if (input == "0") { break; }
            else { Console.WriteLine("Unrecognized input. Please try again"); }
        } while (input != "0");
        Console.WriteLine("Thanks for using PhoneBook Application");
    }
}