using System;
using static System.Console;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hejsan svejsan";
            char[] textArr = new char[] { 'H', 'e', 'j', 's', 'a', 'n', ' ', 's', 'v', 'e', 'j', 's', 'a', 'n' };

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'e')
                {
                    ForegroundColor = ConsoleColor.Red;
                }
                else if (text[i] == 's')
                {
                    ForegroundColor = ConsoleColor.Yellow;
                }
                else if(text[i] == 'n')
                {
                    ForegroundColor= ConsoleColor.Green;
                }
                Write(text[i]);
                ForegroundColor = ConsoleColor.White;
            }

            //string ordEtt = string.Empty;
            //string ordTvå = string.Empty;

            //bool hittadeOrdEtt = false;

            //for (int i = textArr.Length - 1; i >= 0; i--)
            //{
            //    if (textArr[i] == ' ')
            //    {
            //        hittadeOrdEtt = true;
            //    }

            //    else if (hittadeOrdEtt)
            //    {
            //        ordTvå += textArr[i];
            //    }
            //    else
            //    {
            //        ordEtt += textArr[i];
            //    }
            //}

            //string omvändEtt = string.Empty;
            //string omvändTvå = string.Empty;

            //for (int i = ordEtt.Length - 1; i >= 0; i--)
            //{
            //    omvändEtt += ordEtt[i];
            //}
            //for (int i = ordTvå.Length - 1; i >= 0; i--)
            //{
            //    omvändTvå += ordTvå[i];
            //}

            //WriteLine(ordEtt);
            //WriteLine(omvändEtt);
            //WriteLine(ordTvå);
            //WriteLine(omvändTvå);

            //ForegroundColor = ConsoleColor.Green;
            //WriteLine("Skriv något!");
            //var input = ReadLine();
            //ForegroundColor = ConsoleColor.Red;
            //string inputLower = input.ToLower();

            //if (inputLower == "hej")
            //{
            //    WriteLine(inputLower);
            //}
            //else
            //{
            //    WriteLine("Du skrev fel!");
            //}

        }
    }
}