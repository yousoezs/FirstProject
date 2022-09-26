using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{ 
    /*Skapa klassen “Person”, med properties “FirstName”, “LastName” och “Name”.
    Om man ändrar någon av dem, så ska man få ut rätt värden när man läser av de andra. 
    Använd en konstruktor som tar parametrar “firstName” och “lastName” när man instansierar objekten. 
    (I en första enklare version så kan Name vara read-only). Ex1. Person p = new Person(“Anna”, “Berg”); 
    // => p.Name == “Anna Berg” Ex2. p.Name = “Per Lind”; // => p.FirstName == “Per”, p.LastName == “Lind”*/
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private readonly string _name;

        public Person(string FirstName, string LastName)
        {
            _name = Names(FirstName, LastName);
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Names(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            return FirstName + " " + LastName;
        }
    }
}
