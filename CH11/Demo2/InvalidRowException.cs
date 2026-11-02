using System;

namespace Demo2
{
    // Thrown when a row is outside the range [1, 20].
    public class InvalidRowException : ArgumentException
    {
        public InvalidRowException()
            : base("Row must be between 1 and 20")
        {
        }
    }
}
