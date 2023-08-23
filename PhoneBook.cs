using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookApp
{
    class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();


        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }
        public void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }
        public void DisplayContact (string number)
        {
            var contact = Contacts.FirstOrDefault(c  => c.Number == number);
            if (contact == null) { Console.WriteLine("Contact not found\n"); }
            else { DisplayContactDetails(contact); }
        }

        public void ShowAllContacts() 
        {
            foreach (var contact in Contacts) { DisplayContactDetails(contact); }
        }

        public void SearchName(string inputName)
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(inputName)).ToList();
            foreach(var contact in matchingContacts)
            {
                DisplayContactDetails(contact);
            }
            
        }
        public void RemoveContact(Contact contact)
        {
            Contacts.Remove(contact);
        }
        public void RemoveContactByNumber(string number)
        {
            
            var matchingContacts = Contacts.Where(c => c.Number == number).ToList();
            foreach(var contact in matchingContacts)
            {
                RemoveContact(contact);
            }
        }
        
    }
}
