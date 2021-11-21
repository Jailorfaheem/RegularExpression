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
            //taking input email id from user
            Console.Write("Email id : ");
            string name = Console.ReadLine();
            //Regular expression of email id
            string emailid = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$";
            Regex regex = new Regex(emailid);

            if (regex.IsMatch(name))
            {
                Console.WriteLine("Email Id is valid");
            }
            else
            {
                Console.WriteLine("Email Is Invalid,Please Enter Valid Email Id.");
            }

        }
        //This method for validation of mobile number
        public static void MobileNumValid()
        {
            //taking input mobile number from user
            Console.WriteLine("Format of mobile number : 00 0000000000");
            Console.Write("Enter Mobile Number : ");
            string num = (Console.ReadLine());
            //Regular expression of mobile number
            string number = "^[0-9]{1,2}[ ]{1}[0-9]{10}$";
            Regex regex = new Regex(number);

            if (regex.IsMatch(num))
            {
                Console.WriteLine("Mobile Number is valid");
            }
            else
            {
                Console.WriteLine("Mobile number is Invalid,Please Enter Valid MObile Number format.");
            }

        }
        //This method for validation password
        public static void PasswordValid()
        {
            //taking input password from user
            Console.Write("Enter Password : ");
            string name = Console.ReadLine();
            //Regular expression of password
            //Rule 1 : minimum 8 charactors
            //Rule 2 : atleast 1 uppercase
            //Rule 3 : atleast 1 numeric number
            //Rule 4 : ataleast 1 special charactor
            string password = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%&*])[a-zA-Z0-9!@#$%&*]{8,}$";
            Regex regex = new Regex(password);

            if (regex.IsMatch(name))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password Is Invalid,Please Enter Valid Password.");
            }

        }
    }

}