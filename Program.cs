using System;

namespace Aligning_Strings
{
    class Program
    {

        static void Main(string[] args)
        {
            // left align two 10-character values
            // then right align a 10 character value in currency format
            // putting a space and literal pipe character in between
            string format = "(0, -10) | {1,-10} | {2,10:C}";
            Console.WriteLine("First Name | Last Name  | Balance");
            Console.WriteLine("=====================================");

            Console.WriteLine(format, "Bob", "Jones", 101.25M);
            Console.WriteLine(format, "Mary", "Moore", 2100.53M);
            Console.WriteLine(format, "Susan", "Smith", 563.77);
        }
    }
}