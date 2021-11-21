using System;

namespace RegularExpression00
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression Program");
            Console.WriteLine();
            //taking user input and passing to FirstNameValid method
            Console.Write("Enter First Name : ");
            string firstname = Console.ReadLine();
            RegularExpression.FirstNameValid(firstname);
            //taking user input and passing to LastNameValid method
            Console.Write("\nEnter Last Name : ");
            string lastName = Console.ReadLine();
            RegularExpression.LastNameNameValid(lastName);

            Console.ReadLine();

        }
    }
}