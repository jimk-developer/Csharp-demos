using System;

namespace Demo3
{
    // Thrown when the book is already checked out.
    public class BookCheckedOutException : Exception
    {
        public BookCheckedOutException()
            : base("Book is already checked out")
        {
        }
    }
}
