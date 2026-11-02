using System;

namespace Demo3
{
    // Thrown when no book has the code that was entered.
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException()
            : base("Book not found")
        {
        }
    }
}
