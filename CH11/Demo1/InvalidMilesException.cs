using System;

namespace Demo1
{
    // Thrown when miles is not a number or is outside the range [1, 1000].
    public class InvalidMilesException : ArgumentException
    {
        public InvalidMilesException()
            : base("INVALID MILES")
        {
        }
    }
}
