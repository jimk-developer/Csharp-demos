using System;

namespace Demo2
{
    // Thrown when a seat is outside the range [1, 30].
    public class InvalidSeatException : ArgumentException
    {
        public InvalidSeatException()
            : base("Seat must be between 1 and 30")
        {
        }
    }
}
