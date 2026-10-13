namespace Demo2
{
    // A Book object holds one library book.
    // Every field has a getter (read) AND a setter (change).
    public class Book
    {
        private string _title;
        private int _bookId;
        private int _copies;

        public Book(string title, int bookId, int copies)
        {
            _title = title;
            _bookId = bookId;
            _copies = copies;
        }

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string title)
        {
            _title = title;
        }

        public int GetBookId()
        {
            return _bookId;
        }

        public void SetBookId(int bookId)
        {
            _bookId = bookId;
        }

        public int GetCopies()
        {
            return _copies;
        }

        public void SetCopies(int copies)
        {
            _copies = copies;
        }
    }
}
