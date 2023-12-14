using System;
using System.Net.NetworkInformation;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 4));
            Console.WriteLine(Add(2.0m, 2.0m));
            Console.WriteLine(Add(0, 1, false));

        }
    public static int Add(int a, int b)
        {
            return a + b;
        }
    public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
    public static string Add(int a, int b, bool dollarOrDollars)
        {
            int c = a + b;
            if (c == 1)
            {
                return $"{c} dollar";
            }
            else
            {
                return $"{c} dollars";
            }
        }

        //Create a method named Add, that accepts two integers and returns the sum of those two integers
        //        Now create an overload of the Add method to account for being able to add two decimals together
        //        Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
        //        If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
        //         You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”
        //For example:

        //“5 dollars”
        //"1 dollar”
        //“16 dollars”

    }
}
