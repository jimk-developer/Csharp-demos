namespace Demo3
{
    public class Book
    {
        private string _code;
        private string _title;
        private bool _checkedOut;

        public Book(string code, string title, bool checkedOut)
        {
            _code = code;
            _title = title;
            _checkedOut = checkedOut;
        }

        public string Code
        {
            get { return _code; }
        }

        public string Title
        {
            get { return _title; }
        }

        public bool IsCheckedOut
        {
            get { return _checkedOut; }
            set { _checkedOut = value; }
        }
    }
}
