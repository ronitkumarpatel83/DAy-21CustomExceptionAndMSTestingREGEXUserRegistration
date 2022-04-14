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
            //Firstname:
            //Console.WriteLine("\nAtleast 3 character and first character should be Capital letter and rest are small");
            //Console.WriteLine("\nEnter your First name : ");
            //string firstName = Console.ReadLine(); //storing first name entered by user in variable
            //string checkFirstName = validation.FirstNameValidation(firstName); //Calling method to check first name is valid or not with argument
            //if (checkFirstName != "Input is valid")//If not valid then ask user to enter first name again
            //    goto Firstname;
            ////User last name validation
            //Lastname:
            //Console.WriteLine("\nAtleast 3 character and first character should be Capital letter and rest are small");
            //Console.WriteLine("\nEnter your Last name : ");
            //string LastName = Console.ReadLine(); //storing first name entered by user in variable
            //string checkLastName = validation.LastNameValidation(LastName); //Calling method to check first name is valid or not with argument
            //if (checkLastName != "Input is valid")//If not valid then ask user to enter first name again
            //    goto Lastname;
            Email:
            Console.WriteLine("\nWrite your valid Email :");
            Console.WriteLine("\nEnter your email : ");
            string email = Console.ReadLine(); //storing first name entered by user in variable
            string checkEmail = validation.EmailValidation(email); //Calling method to check first name is valid or not with argument
            if (checkEmail != "Input is valid")//If not valid then ask user to enter first name again
                goto Email;
        }
    }
}
