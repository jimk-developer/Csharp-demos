using System;

namespace Demo4
{
    // Thrown when a message contains anything other than the digits 0-9.
    public class InvalidCharacterException : Exception
    {
        public InvalidCharacterException()
            : base("Digits only")
        {
        }
    }
}
