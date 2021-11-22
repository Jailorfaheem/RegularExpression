using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationException
{
    public class UserException
    {
        //declaring instance variable
        public string message;

        public UserException(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// Valids the first name.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="UserRegistrationException.CustomException">invalid</exception>
        public string ValidFirstName()
        {
            string firstname = "^[A-Z]{1}[a-zA-Z]{2}$";
            Regex regex = new Regex(firstname);
            try
            {
                //if condition for matching pattern
                //if condition is true then if block will execute
                if (regex.IsMatch(message))
                {
                    return "valid";
                }
                //else condition for if condition is false then else block will execute
                else
                {
                    return "invalid";
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new CustomException(CustomException.ExceptionType.Argument_Null_Exception, "invalid");
            }

        }
        public string ValidLastName()
        {
            string lastname = "^[A-Z]{1}[a-zA-Z]{2}$";
            Regex regex = new Regex(lastname);
            try
            {
                //if condition for matching pattern
                //if condition is true then if block will execute
                if (regex.IsMatch(message))
                {
                    return "valid";
                }
                //else condition for if condition is false then else block will execute
                else
                {
                    return "invalid";
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new CustomException(CustomException.ExceptionType.Argument_Null_Exception, "invalid");
            }

        }
        public string EmailIdValid()
        {
            string emailid = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$";
            Regex regex = new Regex(emailid);
            try
            {
                //if condition for matching pattern
                //if condition is true then if block will execute
                if (regex.IsMatch(message))
                {
                    return "valid";
                }
                //else condition for if condition is false then else block will execute
                else
                {
                    return "invalid";
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new CustomException(CustomException.ExceptionType.Argument_Null_Exception, "invalid");
            }
        }
        public string MobileNumValid()
        {
            //Regular expression of mobile number
            string number = "^[0-9]{1,2}[ ]{1}[0-9]{10}$";
            Regex regex = new Regex(number);
            try
            {
                //if condition for matching pattern
                //if condition is true then if block will execute
                if (regex.IsMatch(message))
                {
                    return "valid";
                }
                //else condition for if condition is false then else block will execute
                else
                {
                    return "invalid";
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new CustomException(CustomException.ExceptionType.Argument_Null_Exception, "invalid");
            }
        }
        public string ValidPassword()
        {
            //Regular expression of mobile number
            //Regular expression of password
            //Rule 1 : minimum 8 charactors
            //Rule 2 : atleast 1 uppercase
            //Rule 3 : atleast 1 numeric number
            //Rule 4 : ataleast 1 special charactor
            string password = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%&*])[a-zA-Z0-9!@#$%&*]{8,}$";
            Regex regex = new Regex(password);
            try
            {
                //if condition for matching pattern
                //if condition is true then if block will execute
                if (regex.IsMatch(message))
                {
                    return "valid";
                }
                //else condition for if condition is false then else block will execute
                else
                {
                    return "invalid";
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new CustomException(CustomException.ExceptionType.Argument_Null_Exception, "invalid");
            }
        }
    }
}