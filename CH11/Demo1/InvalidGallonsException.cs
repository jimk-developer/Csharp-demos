using System;

namespace Demo1
{
    // Thrown when gallons is not a number or is outside the range [1, 50].
    public class InvalidGallonsException : ArgumentException
    {
        public InvalidGallonsException()
            : base("INVALID GALLONS")
        {
        }
    }
}
