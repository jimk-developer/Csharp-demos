namespace Demo4
{
    // A Movie object holds information about one movie.
    public class Movie
    {
        private string _title;
        private string _director;
        private int _year;

        public Movie(string title, string director, int year)
        {
            _title = title;
            _director = director;
            _year = year;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetDirector()
        {
            return _director;
        }

        public int GetYear()
        {
            return _year;
        }
    }
}
