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
        /// validate fist name using lambda function
        /// </summary>
        /// <returns></returns>
        public string ValidFirstName()
        {
            string firstNamePattern = "^[A-Z]{1}[a-zA-Z]{2}$";
            bool testFirstName(string firstName) => (Regex.IsMatch(firstName, firstNamePattern));
            bool result = testFirstName(message);
            //Regex regex = new Regex(firstname);
            try
            {
                //if condition for matching pattern
                //if condition is true then if block will execute
                if (result)
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
        /// <summary>
        /// validate last name using lambda function
        /// </summary>
        /// <returns></returns>
        public string ValidLastName()
        {
            string larstNamePattern = "^[A-Z]{1}[a-zA-Z]{2}$";
            bool testLastName(string larstName) => (Regex.IsMatch(larstName, larstNamePattern));
            bool result = testLastName(message);
            try
            {
                //if condition for matching pattern
                //if condition is true then if block will execute
                if (result)
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
        /// <summary>
        /// validate email id using lambda function
        /// </summary>
        /// <returns></returns>
        public string EmailIdValid()
        {
            string emailIdPattern = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$";
            bool testEmailId(string emailId) => (Regex.IsMatch(emailId, emailIdPattern));
            bool result = testEmailId(message);
            try
            {
                //if condition for matching pattern
                //if condition is true then if block will execute
                if (result)
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
        /// <summary>
        /// validate mobile number using lambda function
        /// </summary>
        /// <returns></returns>
        public string MobileNumValid()
        {
            //Regular expression of mobile number
            string numberPattern = "^[0-9]{1,2}[ ]{1}[0-9]{10}$";
            bool testMobNum(string mobNum) => (Regex.IsMatch(mobNum, numberPattern));
            bool result = testMobNum(message);
            try
            {
                //if condition for matching pattern
                //if condition is true then if block will execute
                if (result)
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
        /// <summary>
        /// validate password using lambda function
        /// </summary>
        /// <returns></returns>
        public string ValidPassword()
        {
            //Regular expression of mobile number
            //Regular expression of password
            //Rule 1 : minimum 8 charactors
            //Rule 2 : atleast 1 uppercase
            //Rule 3 : atleast 1 numeric number
            //Rule 4 : ataleast 1 special charactor
            string passwordPattern = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%&*])[a-zA-Z0-9!@#$%&*]{8,}$";
            bool testPassword(string password) => (Regex.IsMatch(password, passwordPattern));
            bool result = testPassword(message);
            try
            {
                //if condition for matching pattern
                //if condition is true then if block will execute
                if (result)
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