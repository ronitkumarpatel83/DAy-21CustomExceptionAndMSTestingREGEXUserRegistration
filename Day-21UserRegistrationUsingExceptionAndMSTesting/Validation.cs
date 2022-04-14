using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_21UserRegistrationUsingExceptionAndMSTesting
{
    public class Validation
    {
        public string FirstNameValidation(string FirstName)
        {
            try
            {
                string pattern = "^[A-Z][a-z]{2,}$"; // Creating REGEX pattern
                if (Regex.IsMatch(FirstName, pattern)) //For checking regex are valid or invalid
                {
                    Console.WriteLine("The First name is : " + FirstName);
                    return "Input is valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionValidation.INVALID_INPUT, "Input is not valid");
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
        public string LastNameValidation(string LastName)
        {
            try
            {
                string pattern = "^[A-Z][a-z]{2,}$"; // Creating REGEX pattern
                if (Regex.IsMatch(LastName, pattern)) //For checking regex are valid or invalid
                {
                    Console.WriteLine("The Last name is : " + LastName);
                    return "Input is valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionValidation.INVALID_INPUT, "Input is not valid");
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
        public string EmailValidation(string email)
        {
            try
            {
                string pattern = "^[0-9a-zA-Z]+[./+_-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9-]+[.][a-zA-Z]{2,}([.][a-zA-Z]{2,}){0,1}$"; // Creating REGEX pattern
                if (Regex.IsMatch(email, pattern)) //For checking regex are valid or invalid
                {
                    Console.WriteLine("My email id : " + email);
                    return "Input is valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionValidation.INVALID_INPUT, "Input is not valid");
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
        public string MobileNumberValidation(string Number)
        {
            try
            {
                string pattern = "^[0-9]{1,3}[ ][0-9]{10}$"; // Creating REGEX pattern
                if (Regex.IsMatch(Number, pattern)) //For checking regex are valid or invalid
                {
                    Console.WriteLine("My number id is : " + Number);
                    return "Input is valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionValidation.INVALID_INPUT, "Input is not valid");
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message; 
            }
        }
        public string PasswordValidation(string pswd)
        {

            string pattern = "^((?=.{8,}$)(?=.*[0-9])(?=.*[A-Z])[A-Za-z0-9]{0,30}?[@~!#$%^&+*]{1}[a-zA-Z0-9]{0,30})$"; // Creating REGEX pattern
            try
            {
                if (Regex.IsMatch(pswd, pattern)) //For checking regex are valid or invalid
                {
                    Console.WriteLine("My password id is : " + pswd);
                    return "Input is valid";
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionValidation.INVALID_INPUT, "Input is not valid");
                }
            }
            catch(CustomException ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }
    }
}
