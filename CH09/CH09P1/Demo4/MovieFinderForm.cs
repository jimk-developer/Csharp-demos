namespace Demo4
{
    public partial class MovieFinderForm : Form
    {
        Movie[] movies = new Movie[5];

        public MovieFinderForm()
        {
            InitializeComponent();

            movies[0] = new Movie("Toy Story", "John Lasseter", 1995);
            movies[1] = new Movie("Jurassic Park", "Steven Spielberg", 1993);
            movies[2] = new Movie("Back to the Future", "Robert Zemeckis", 1985);
            movies[3] = new Movie("Finding Nemo", "Andrew Stanton", 2003);
            movies[4] = new Movie("Star Wars", "George Lucas", 1977);
        }

        // ---------- Form methods (not in the Movie class) ----------

        // Searches by title OR director. Returns the index of the
        // first match, or -1 if nothing matches.
        private int FindMovie(string searchText)
        {
            string search = searchText.Trim().ToLower();

            if (search == "")
            {
                return -1;
            }

            for (int i = 0; i < movies.Length; i++)
            {
                string title = movies[i].GetTitle().ToLower();
                string director = movies[i].GetDirector().ToLower();

                // Contains() lets part of a name match ("lucas" finds George Lucas)
                if (title.Contains(search) || director.Contains(search))
                {
                    return i;
                }
            }

            return -1;
        }

        // Displays the movie at this index, or "Movie Not Found"
        private void ShowMovie(int index)
        {
            if (index >= 0 && index < movies.Length)
            {
                lblTitle.Text = movies[index].GetTitle();
                lblDirector.Text = movies[index].GetDirector();
                lblYear.Text = movies[index].GetYear().ToString();
            }
            else
            {
                lblTitle.Text = "Movie Not Found";
                lblDirector.Text = "Movie Not Found";
                lblYear.Text = "Movie Not Found";
            }
        }

        // ---------- Button click ----------

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int index = FindMovie(txtSearch.Text);
            ShowMovie(index);
        }
    }
}
