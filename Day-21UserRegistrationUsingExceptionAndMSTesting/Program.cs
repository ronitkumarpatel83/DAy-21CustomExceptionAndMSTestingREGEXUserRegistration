using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_21UserRegistrationUsingExceptionAndMSTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Validation validation = new Validation();
            Console.WriteLine("MSTesting");
            Console.WriteLine("Welcome to C# User's Information validation using Regular Expression");
            //User first name validation
            Firstname:
            Console.WriteLine("\nAtleast 3 character and first character should be Capital letter and rest are small");
            Console.WriteLine("\nEnter your first name : ");
            string firstName = Console.ReadLine(); //storing first name entered by user in variable
            string checkFirstName = validation.FirstNameValidation(firstName); //Calling method to check first name is valid or not with argument
            if (checkFirstName != "Input is valid")//If not valid then ask user to enter first name again
                goto Firstname;
        }
    }
}
