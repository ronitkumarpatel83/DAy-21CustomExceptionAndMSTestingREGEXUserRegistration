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
            Console.WriteLine("\nEnter your First name : ");
            string firstName = Console.ReadLine(); //storing first name entered by user in variable
            string checkFirstName = validation.FirstNameValidation(firstName); //Calling method to check first name is valid or not with argument
            if (checkFirstName != "Input is valid")//If not valid then ask user to enter first name again
                goto Firstname;
            //User last name validation
            Lastname:
            Console.WriteLine("\nAtleast 3 character and first character should be Capital letter and rest are small");
            Console.WriteLine("\nEnter your Last name : ");
            string LastName = Console.ReadLine(); //storing first name entered by user in variable
            string checkLastName = validation.LastNameValidation(LastName); //Calling method to check first name is valid or not with argument
            if (checkLastName != "Input is valid")//If not valid then ask user to enter first name again
                goto Lastname;
            //User email id validation
            Email:
            Console.WriteLine("\nWrite your email example :-ronitkumarpate83@gmail.com");
            Console.WriteLine("\nEnter your email : ");
            string email = Console.ReadLine(); //storing first name entered by user in variable
            string checkEmail = validation.EmailValidation(email); //Calling method to check first name is valid or not with argument
            if (checkEmail != "Input is valid")//If not valid then ask user to enter first name again
                goto Email;
            //User Mobile Number Validation
            MobileNumber:
            Console.WriteLine("\nWrite your phone number Example 91 7008427274 ");
            Console.WriteLine("\nEnter your Mobile Number : ");
            string MobileNumber = Console.ReadLine(); //storing first name entered by user in variable
            string checkmobileNumber = validation.MobileNumberValidation(MobileNumber); //Calling method to check first name is valid or not with argument
            if (checkmobileNumber != "Input is valid")//If not valid then ask user to enter first name again
                goto MobileNumber;
            //User Password Validation
            Password:
            Console.WriteLine("\nWrite a password :\n->Password should have minimum 8 character\n->Password should have at least One upper case");
            Console.WriteLine("->Password should have at least One numeric\n->Password have exactly One special character");
            Console.WriteLine("\nEnter your password : ");
            string Password = Console.ReadLine(); //storing first name entered by user in variable
            string checkpassword = validation.PasswordValidation(Password); //Calling method to check first name is valid or not with argument
            if (checkpassword != "Input is valid")//If not valid then ask user to enter first name again
                goto Password;

        }
    }
}
