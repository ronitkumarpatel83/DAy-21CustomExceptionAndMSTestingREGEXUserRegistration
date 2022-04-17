using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day_21UserRegistrationUsingExceptionAndMSTesting;
using System;

namespace TestForValidation
{
    [TestClass]
    public class UserInputTesting
    {
        Validation validation;
        [TestInitialize]
        public void SetUp()
        {
            // common Arrange
            validation = new Validation();
        }
        [TestMethod]
        //Checking for multiple first name
        [DataRow("kkkkk", "Input is not valid")]
        [DataRow("RKP", "Input is not valid")]
        [DataRow("Ronit","Input is valid")]
        public void GivenFirstNameValidation(string firstName, string expected) // Testing for Firstname Validation
        {
            try
            {
                //Act
                Validation first = new Validation(firstName);
                string actual = first.FirstNameValidation();
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        //Checking for multiple first name
        [DataRow("patel", "Input is not valid")]
        [DataRow("RKP", "Input is not valid")]
        [DataRow("Patel", "Input is valid")]
        public void GivenLastNameValidation(string lastName, string expected) // Testing for Firstname Validation
        {
            try
            {
                //Act
                string actual = validation.LastNameValidation(lastName);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        //Checking for multiple first name
        [DataRow("abc@abc@gmail.com", "Input is not valid")]
        [DataRow("abc..2002@gmail.com", "Input is not valid")]
        [DataRow("abc@yahoo.com", "Input is valid")]
        [DataRow("abc@1.com", "Input is valid")]
        public void EmailValidation(string email, string expected) // Testing for Firstname Validation
        {
            try
            {
                //Act
                string actual = validation.EmailValidation(email);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        //Checking for multiple first name
        [DataRow("919123456789", "Input is not valid")]
        [DataRow("91 9123456789", "Input is valid")]
        public void PhoneNumberValidation(string number, string expected) // Testing for Firstname Validation
        {
            try
            {
                //Act
                string actual = validation.MobileNumberValidation(number);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [TestMethod]
        //Checking for multiple first name
        [DataRow("abcdefghi", "Input is not valid")]
        [DataRow("abcde12344", "Input is not valid")]
        [DataRow("ABcde123", "Input is not valid")]
        [DataRow("ABcde@@12344", "Input is not valid")]
        [DataRow("AbCdEf12@", "Input is valid")]
        [DataRow("Aabcde@12345", "Input is valid")]
        public void PasswordValidation(string number, string expected) // Testing for Firstname Validation
        {
            try
            {
                //Act
                string actual = validation.PasswordValidation(number);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        UserRegistrationReflector userRegistrationReflector = new UserRegistrationReflector();
        /// <summary>
        /// Create a object of Validation class using reflection
        /// </summary>
        [TestCategory("Reflection")]
        [TestMethod]
        public void GivenClassNameShoulReturnObject()
        {
            object expected = new Validation();
            object actual = userRegistrationReflector.CreateValidationObject("Day_21UserRegistrationUsingExceptionAndMSTesting.Validation", "Validation");
            expected.Equals(actual);
        }
        /// <summary>
        /// Given Class Name When Improper Should Throw InvalidException
        /// </summary>
        [TestCategory("Reflection")]
        [TestMethod]
        public void GivenInvalidClassThrowException()
        {
            try
            {
                object expected = new Validation();
                object actual = userRegistrationReflector.CreateValidationObject("Day_21UserRegistrationUsingExceptionAndMSTesting.valid", "valid");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }
        /// <summary>
        /// Given Validation Class Name Should Return Validation object with parameter
        /// </summary>
        [TestCategory("Reflection")]
        [TestMethod]
        public void GivenClassNameShoulReturnParameterizedObject()
        {
            string input = "Ronit";
            object expected = new Validation(input);
            object actual = userRegistrationReflector.CreateValidationParameterizedObject("Day_21UserRegistrationUsingExceptionAndMSTesting.Validation", "Validation", input);
            expected.Equals(actual);
        }

        /// <summary>
        /// Given Class Name When Improper Should Throw InvalidException
        /// </summary>
        [TestCategory("Reflection")]
        [TestMethod]
        public void GivenInvalidClassNameWithMessageThrowException()
        {
            try
            {
                string input = "Ronit";
                object expected = new Validation(input);
                object actual = userRegistrationReflector.CreateValidationParameterizedObject("Day_21UserRegistrationUsingExceptionAndMSTesting.valid", "valid", input);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }
        /// <summary>
        /// Given FirstName validation Using Reflection When Proper Should Return Input is valid invoking a method
        /// </summary>
        [TestCategory("Reflection")]
        [TestMethod]
        public void GivenMethodNameWithInputReturnsValidity()
        {
            string input = "Ronit";
            string expected = "Input is valid";
            string actual = "";
            try
            {
                actual = userRegistrationReflector.InvokeMethod(input, "FirstNameValidation");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Method not found", ex.Message);
            }
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Given Invalid method name should throw the exception
        /// </summary>
        [TestCategory("Reflection")]
        [TestMethod]
        public void GivenInvalidMethodNameWithInputThrowException()
        {
            string input = "Ronit";
            string expected = "Input is valid";
            string actual = "";
            try
            {
                actual = userRegistrationReflector.InvokeMethod(input, "FirstName");
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Method not found", ex.Message);
            }
        }
    }
}
