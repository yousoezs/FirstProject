namespace ConsoleApp15
{
    internal class Program
    {
        /*Skapa klassen “Person”, med properties “FirstName”, “LastName” och “Name”.
         Om man ändrar någon av dem, så ska man få ut rätt värden när man läser av de andra. 
        Använd en konstruktor som tar parametrar “firstName” och “lastName” när man instansierar objekten. 
        (I en första enklare version så kan Name vara read-only). Ex1. Person p = new Person(“Anna”, “Berg”); 
        // => p.Name == “Anna Berg” Ex2. p.Name = “Per Lind”; // => p.FirstName == “Per”, p.LastName == “Lind”*/
        static void Main(string[] args)
        {
            Person persons = new Person("Toni", "Skoro");
            persons.FirstName = Console.ReadLine();
            persons.LastName = Console.ReadLine();

            Console.WriteLine(persons.Name);

        }
    }
}