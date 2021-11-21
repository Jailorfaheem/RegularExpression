using System;

namespace RegularExpression00
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression Program");
            Console.WriteLine();
            //taking user input of first name
            Console.Write("Enter First Name : ");
            string firstname = Console.ReadLine();
            RegularExpression.FirstName(firstname);
            Console.ReadLine();

        }
    }
}
