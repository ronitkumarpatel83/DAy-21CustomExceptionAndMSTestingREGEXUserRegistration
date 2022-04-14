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
                string actual = validation.FirstNameValidation(firstName);
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
                string actual = validation.FirstNameValidation(lastName);
                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException ex) // catch exception if input is not valid or null or empty
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
