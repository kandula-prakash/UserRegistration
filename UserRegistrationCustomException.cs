using System;
using System.Runtime.Serialization;

namespace UserRegistration
{

    public class UserRegistrationCustomException : Exception
    {
        private readonly ExceptionType type;

        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            INVALID_INPUT
        }


        public UserRegistrationCustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
