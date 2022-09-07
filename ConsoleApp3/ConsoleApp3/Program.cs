using System;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;
namespace ConsoleApp3
{
    internal class Program
    {
        //Gör ett program som ber användaren mata in en text.
        //Be sedan användaren mata in en sträng som är en del av den första texten. 
        //Skriv ut hela texten med den del man angav markerad i en annan färg. 
        //Ex.Användare matar in “abcdefghijklmnopqrstuvxyz”, och sedan “defg”. 
        //Programmet ska då skriva ut: abcdefghijklmnopqrstuvxyz
        static void Main(string[] args)
        {
            WriteLine("Mata in en text!");
            //Här ber vi användaren mata in en text med metoden ReadLine()
            string input1 = ReadLine();
            WriteLine("Mata nu in en sträng från din text!");
            string input2 = ReadLine();

            //Här skapar vi en int variabel som ska ta reda på första positionen i input2.
            int index1 = input1.IndexOf(input2);
            //var counter är skapad för att få själva längden av input2 för att veta hur lång den är i siffer värde.
            var counter = input2.Length;
            //Här skriver vi ut första delen av texten, med start position 0 och fram till första position av indexet vi hittade i index1.
            Write(input1.Substring(0, index1));
            //Här ändrar vi färg till grönt!
            ForegroundColor = ConsoleColor.Green;
            //Här skriver vi att datorn ska starta från första positionen vi hittade förut, samt sätta ihop ordet vi har i counter.
            //Med första indexet, - första indexet också
            Write(input1.Substring(index1, counter + index1 - index1));
            ForegroundColor = ConsoleColor.White;
            //Här tar vi reda på det sista indexet med hjälpa av lite matte.
            //vi tar input1.Length, längden av första texten - inom parantes (index1 + counter) för att vi måste ta första position
            //samt ordet vi har efterhand - hela längden av input1. för att få ut rätt ord i sista index.
            var lastIndex1 = input1.Length - (index1 + counter);
            //Här skriver vi ut nu, första position hittad + counter, alltså det färgade ordet. samt sista ordet med hjälp av lastIndex1.
            Write(input1.Substring(index1 + counter, lastIndex1));

            ReadKey();
        }
    }
}