using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_21UserRegistrationUsingExceptionAndMSTesting
{
    public class CustomException:Exception
    {
        public enum ExceptionValidation
        {
            INVALID_INPUT
        }
        public ExceptionValidation type;
        public CustomException(ExceptionValidation type, string message) : base(message)
        {
            this.type = type; 
        }
    }
}
