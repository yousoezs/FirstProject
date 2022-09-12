using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Car
    {
        //Privat variabel för klassen Car
        private string _name;

        //Skapar en publik string property med namnet Name, get {} returnerar variabeln _name.
        //set{} sätter värdet _name till värdet som hämtas
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Level
        {
            get;
            set;
        }
        private string _characterClass;
        public string CharacterClass
        {
            get { return _characterClass; }
            set { _characterClass = value; }
        }
        public bool Alive { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Your name: {Name}.\nYour level: {Level}.\nAre you alive: {Alive}");
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Level: {Level}\n" +
                $"Alive Status: {Alive} ";
        }
    }
}
