using System.Numerics;
using static System.Console;

namespace Codewars_test
{
    //Complete the function that accepts a string parameter, and reverses each word in the string. 
    //All spaces in the string should be retained.
    internal class Program
    {
        //Inputs of strings, several indexes.
        //output should be reversed words with spaces contained.
        //create a string array that saves every word after space.
        //all spaces must be saved.
        //for every word read, reverse and return it at the same place.
        //return output with every word reversed and spaces retained.
        static void Main(string[] args)
        {

        }
        public static string ToAlternatingCase(this string s)
        {
            string newString = String.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == Char.ToUpper(s[i]))
                {
                    newString += s[i].ToLower();
                }
                else if (s[i] == s[i].ToLower())
                {
                    newString += s[i].ToUpper();
                }
                else
                {
                    newString += s[i];
                }
            }
            return newString;
        }
    }
}