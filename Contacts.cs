using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookApp;

class Contact
{ 
    public Contact(string name, string phoneNumber)
    {
        Name = name;
        Number = phoneNumber;
    }

    public string Name { get; set; }
    public string Number { get; set; }

    // Comment
}
