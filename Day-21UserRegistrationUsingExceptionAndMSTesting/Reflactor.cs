using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_21UserRegistrationUsingExceptionAndMSTesting
{
    public class UserRegistrationReflector
    {
        public object CreateValidationObject(string className, string constructor)
        {
            try
            {
                if (className == null || constructor == null) // If any field null then throw exception
                {
                    throw new CustomException(CustomException.ExceptionValidation.NULL_INPUT, "Class name or constructor name should not be null");
                }
                string pattern = "." + constructor + "$"; // regex for class
                Match result = Regex.Match(className, pattern); // Checking that Class name and constructor name is equal or not             

                if (result.Success) // If class name matched with constructor name then 
                {
                    try
                    {
                        Assembly assembly = Assembly.GetExecutingAssembly();
                        Type moodAnalyzerType = assembly.GetType(className); // Get the class name type from assembly
                        return Activator.CreateInstance(moodAnalyzerType);
                    }
                    catch (ArgumentNullException) //If class not found in assembly then throw exception
                    {
                        throw new CustomException(CustomException.ExceptionValidation.CLASS_NOT_FOUND, "Class not found");
                    }
                }
                else // Constructor name not matched with class name then throw exception like constructor not found
                {
                    throw new CustomException(CustomException.ExceptionValidation.CONSTRUCTOR_NOT_FOUND, "Constructor not found");
                }
            }
            catch (CustomException e)
            {
                return e.Message;
            }
        }

        public object CreateValidationParameterizedObject(string className, string constructor, string input)
        {
            try
            {
                if (className == null || constructor == null || input == null) // If any field is null then throw exception
                {
                    throw new CustomException(CustomException.ExceptionValidation.NULL_INPUT, "Class name,constructor name or message should not be null");
                }
                Type type = typeof(Validation); // Getting a type of Validation class
                if (type.Name.Equals(className) || type.FullName.Equals(className)) // If actual type name of Validation class is matching with given class name throw create object
                {
                    if (type.Name.Equals(constructor)) // If class name is match with constructor then create parameterized object of class
                    {
                        ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) }); //Getting constructor which hase one parameter of type string
                        return constructorInfo.Invoke(new object[] { input }); //Invoking a object
                    }
                    else // else throw exception constructor not found
                    {
                        throw new CustomException(CustomException.ExceptionValidation.CONSTRUCTOR_NOT_FOUND, "Constructor not found");
                    }
                }
                else  //else throw exception class not found
                {
                    throw new CustomException(CustomException.ExceptionValidation.CLASS_NOT_FOUND, "Class not found");
                }
            }
            catch (CustomException e)
            {
                return e.Message;
            }
        }

        public string InvokeMethod(string input, string methodName) // creating a method for invoking method
        {
            try
            {
                Type type = typeof(Validation); // Getting type of Validation class
                MethodInfo methodInfo = type.GetMethod(methodName); // Getting method information using reflection
                object validationObject = CreateValidationParameterizedObject("Day_21UserRegistrationUsingExceptionAndMSTesting.Validation", "Validation", input);//Creating a parameterized object of Validation class using reflection
                object info = methodInfo.Invoke(validationObject, null); //Invoking method using reflection
                return info.ToString(); //returning that user input is valid or not
            }
            catch (NullReferenceException) //If method not found then throw exception
            {
                throw new CustomException(CustomException.ExceptionValidation.METHOD_NOT_FOUND, "Method not found");
            }
        }

    }
}