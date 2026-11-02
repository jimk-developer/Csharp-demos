using System;

namespace Demo3
{
    // Thrown when no book code is entered.
    public class NoBookCodeException : Exception
    {
        public NoBookCodeException()
            : base("You must enter a book code")
        {
        }
    }
}
