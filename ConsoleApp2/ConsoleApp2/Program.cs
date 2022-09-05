using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name;
            //string password;
            //string number;
            //int num1;
            //int num2;

            //WriteLine("Vad är ditt namn?");
            //name = ReadLine();
            //WriteLine("Skriv ett nummer för antal hälsningar du vill ha!");
            //num1 = int.Parse(ReadLine());
            //for (int i = 0; i < num1; i++)
            //{
            //    WriteLine(name);
            //}
            //WriteLine($"Hej {name}! Hitta på något lösernord nu!");

            //password = ReadLine();
            //WriteLine("Bekräfta nu ditt lösernord för att se om det funkar!");
            //if (ReadLine() == password)
            //{
            //    WriteLine($"Du Skrev rätt lösernord! Hitta på något tal nu {name}.");
            //    num1 = int.Parse(ReadLine());
            //    WriteLine($"Du skrev numret: {num1}");
            //}
            //else
            //{
            //    WriteLine("Ditt lösernord var fel, hej då!");
            //}
            //WriteLine("Skriv ett tal 0 - 150");
            //number = ReadLine();
            //if (int.TryParse(number, out int theNumber))
            //    if (theNumber > 100)
            //        WriteLine("numret är större än 100!");
            //    else if (theNumber < 100)
            //        WriteLine("Talet är mindre än 100!");
            //    else if (theNumber == 100)
            //        WriteLine("Talet är lika med 100!");
            //    else
            //    {
            //        WriteLine("Inget skrivet tal kom in! Går vidare i programmet!");
            //    }

            //WriteLine("Dags för att skriva en massa tal! Skriv något tal.");
            //while (ReadLine() != " ")
            //{
            //    WriteLine("Välkommen till miniräknaren, skriv ett tal!");
            //    num1 = int.Parse(ReadLine());
            //    WriteLine($"Grymt, du skrev: {num1}. skriv ett till tal!");
            //    num2 = int.Parse(ReadLine());
            //    int sum = num1 + num2;
            //    WriteLine($"Du skrev: {num2}. Summan av talen är: {num1 + num2}, medelvärdet av talen är {sum / 2}." +
            //            $"Fortsätt skriv.");
            //    WriteLine("För att komma ut ur miniräknaren och fortsätta så skicka ett mellanslag!");
            //}

            //WriteLine("Skriv ett nytt tal för den nya miniräknaren");
            //num1 = int.Parse(ReadLine());
            //WriteLine("Välj nu mellan ett av nedanstående tecken \n+ - * /");
            //if (ReadLine() == "+")
            //{
            //    WriteLine("Du valde plus, Skriv ett till tal nu för att få summan!");
            //    num2 = int.Parse(ReadLine());
            //    WriteLine($"Summan av dina tal {num1} + {num2} blir: {num1 + num2}");
            //}
            //else if (ReadLine() == "-")
            //{
            //    WriteLine("Du valde minus, skriv ett tal för att få substraktionen av talet!");
            //    num2 = int.Parse(ReadLine());
            //    WriteLine($"Substraktionen av {num1} - {num2} blir: {num1 - num2}");
            //}
            //else if (ReadLine() == "*")
            //{
            //    WriteLine("Du valde multiplikation, skriv ett till tal för att få produkten.");
            //    num2 = int.Parse(ReadLine());
            //    WriteLine($"Produkten av dina tal {num1} * {num2} blir {num1 * num2}");
            //}
            //else if (ReadLine() == "/")
            //{
            //    WriteLine("Du valde division skriv ett till tal!");
            //    num2 = int.Parse(ReadLine());
            //    WriteLine($"Kvoten av dina tal {num1} / {num2} blir: {num1 / num2}");
            //}
            //else
            //    WriteLine("Sämst!");
            //WriteLine("Skriv en månad!");

            //switch (ReadLine())
            //{
            //    case "1":
            //        WriteLine("Januari");
            //        break;
            //    case "2":
            //        WriteLine("Februari");
            //        break;
            //    case "3":
            //        WriteLine("Mars");
            //        break;
            //    case "4":
            //        WriteLine("April");
            //        break;
            //    case "5":
            //        WriteLine("Maj");
            //        break;
            //    case "6":
            //        WriteLine("Juni");
            //        break;
            //    case "7":
            //        WriteLine("Juli");
            //        break;
            //    case "8":
            //        WriteLine("Augusti");
            //        break;
            //    case "9":
            //        WriteLine("September");
            //        break;
            //    case "10":
            //        WriteLine("Oktober");
            //        break;
            //    case "11":
            //        WriteLine("November");
            //        break;
            //    case "12":
            //        WriteLine("December");
            //        break;
            //    default:
            //        WriteLine("Fel input!");
            //        break;
            //}

            //for (int i = 1; i <= 32768; i *= 2)
            //{
            //    WriteLine(i);
            //}

            //int slumpTal = new Random().Next(1, 100);

            //WriteLine("Gissa på ett tal mellan 1-100!");
            //while (true)
            //{
            //    num1 = int.Parse(ReadLine());
            //    if (num1 < slumpTal)
            //    {
            //        WriteLine("Du gissade för lågt, gissa högre!");
            //    }
            //    else if (num1 > slumpTal)
            //    {
            //        WriteLine("Du gissade för högt, gissa lägre!");
            //    }
            //    else if (num1 == slumpTal)
            //    {
            //        WriteLine($"Du gissade korrekt! Talet var {slumpTal}");
            //        break;
            //    }
            //}

            //WriteLine($"Skriv en sträng {name}!");
            //string text = ReadLine();

            //foreach (var c in text)
            //{
            //    Write(c + " ");
            //}

            //string[] siffror = new string[] { "noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };
            //string sick = ReadLine();
            //foreach (var siff in sick)
            //{
            //    //Använder ConvertToInt16 för att man kan inte implicit casta en char till int. sedan använder jag ToString för att få ut texten
            //    //av indexen i arrayen.
            //    Write($"{siffror[ToInt16(siff.ToString())]}");
            //}
            //WriteLine("Hur många tal vill du ha!");
            //int[] array = new int[int.Parse(ReadLine())];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    WriteLine("Skriv nu alla tal i ordning, exempelvis... 1, 7, 23 ,43");
            //    array[i] = int.Parse(ReadLine());
            //}
            //for (int z = array.Length - 1; z >= 0; z--)
            //{
            //    WriteLine(array[z]);
            //}

            //WriteLine("Skriv in en text för att få den utskrivet baklänges!");
            //string textil = ReadLine();
            //for(int i = 0; i < textil.Length; i++)
            //{
            //}
            //    for(int z = textil.Length -1; z >= 0; z--)
            //    {
            //        Write(textil[z]);
            //    }

            //WriteLine("mata in en text!");
            //string texta = ReadLine();
            //string[] vocals = new string[] { "a", "e", "i", "o", "u", "y", "å", "ä", "ö" };
            //for (int i = 0; i < texta.Length; i++)
            //{
            //    for (int j = 0; j < vocals.Length; j++)
            //    {
            //        //contains() kollar chars i arrayen finns i texta.
            //        if (texta.Contains(vocals[j]))
            //        {
            //            //replace() retunerar den byter inte plats! 
            //            texta = texta.Replace(vocals[j], "*");
            //        }
            //    }
            //}
            ////skriver ut det sista resultatet med vokalerna borta.
            //WriteLine(texta);

            //Ett palindrom är ett ord som blir samma framlänges som baklänges.
            //Be användaren skriva in ett ord och ange sedan om det är ett palindrom eller inte.

            //WriteLine("Här kollar vi om texten du skriver är ett palindrom eller inte!");
            //string texta = "";
            //string textb = "";
            //WriteLine("Skriv in en text!");
            //texta = ReadLine();
            //textb = texta;
            //for (int i = 0; i < textb.Length; i++)
            //{
            //    for (int j = textb.Length - 1; j >= 0; j--)
            //    {
            //        Write(textb[j]);
            //        if (textb[j] == texta[i])
            //        {
            //            WriteLine($"Detta är ett palindrom eftersom orden blir densamma baklänges! {textb} och {texta}");
            //        }
            //        else
            //        {
            //            WriteLine($"detta är inte ett palindrom eftersom orden är inte samma! {textb} och {texta}");
            //        }
            //    }
            //}

            //Gör om uppgift 6 så man kan mata in allt på en rad(första talet, operator, andra talet).
            //Ignorera inmatade mellanslag i strängen.
            //Om man t.ex.matar in strängen “34 - 14”, så ska programmet skriva ut “= 20”.

            WriteLine("Skriv ett tal och välj mellan ett av 4 tecken, -, +, *, eller /.");
            char[] teckenArray = new char[] { '-', '+', '/', '*' };
            string tal = ReadLine();

            string output = tal.Replace(" ", ""); //Tar bort alla mellanslag (white space)
            string[] tals = output.Split(teckenArray); //Viktigt att det är Char och inte string du kollar igenom!

            double tal1 = double.Parse(tals[0]); //Gör om första indexet i tals arrayen till en double.
            double tal2 = double.Parse(tals[1]); //Gör om andra indexet i tals arrayen till en double.

            //Här kollar vi om output innehåller ett +, -, / eller * tecken. Sen gör följande.
            if (output.Contains('+'))
            {
                WriteLine($"= {tal1 + tal2}");
            }
            else if (output.Contains('-'))
            {
                WriteLine($"= {tal1 - tal2}");
            }
            else if (output.Contains('/'))
            {
                WriteLine($"= {tal1 / tal2}");
            }
            else if (output.Contains('*'))
            {
                WriteLine($"= {tal1 * tal2}");
            }
            else
                WriteLine("Wrong input!");
            ReadKey();

        }
    }
}
