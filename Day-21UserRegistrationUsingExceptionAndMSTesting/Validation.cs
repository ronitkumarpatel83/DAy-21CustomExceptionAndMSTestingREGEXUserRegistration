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

    }
}
