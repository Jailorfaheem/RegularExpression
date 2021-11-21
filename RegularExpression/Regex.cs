using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpression00
{
    public class RegularExpression
    {
        //This method for matching pattern of first name
        public static void FirstNameValid(string name)
        {
            //Regular expression for first letter is capital and maximum charactor is 3
            string firstname = "^[A-Z]{1}[a-zA-Z]{2}$";
            Regex regex = new Regex(firstname);
            //if condition for matching pattern
            //if condition is true then if block will execute
            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is valid name");
            }
            //else condition for if condition is false then else block will execute
            else
            {
                Console.WriteLine(name + " is invalid first name. Please start with capital letter and only take maximum 3 charactors");
            }
        }
        //This method for validate last name
        public static void LastNameNameValid(string name)
        {
            //Regular expression for first letter is capital and maximum charactor is 3
            string firstname = "^[A-Z]{1}[a-zA-Z]{2}$";
            Regex regex = new Regex(firstname);
            //if condition for matching pattern
            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is valid name");
            }
            //else condition for if condition is false then else block will execute
            else
            {
                Console.WriteLine(name + " is invalid last name. Please start with capital letter and take maximums 3 charactors");
            }
        }
        //This method for validation of email id
        public static void EmailValid()
        {
            Console.Write("Email id : ");
            string name = Console.ReadLine();

            string emailid = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$";
            Regex regex = new Regex(emailid);

            if (regex.IsMatch(name))
            {
                Console.WriteLine("Email Id is valid");
            }
            else
            {
                Console.WriteLine("Email Is Invalid,Please Enter Valid email Id");
            }

        }
    }

}