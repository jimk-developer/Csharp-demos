namespace Demo4;

public partial class MainForm : Form
{
    private List<Book> books = new List<Book>();

    public MainForm()
    {
        InitializeComponent();

        books.Add(new Book("Pride and Prejudice", "Jane Austen", 1813, "Romance"));
        books.Add(new Book("Frankenstein", "Mary Shelley", 1818, "Horror"));
        books.Add(new Book("Treasure Island", "Robert Louis Stevenson", 1883, "Adventure"));
        books.Add(new Book("The Time Machine", "H. G. Wells", 1895, "Science fiction"));
        books.Add(new Book("Dracula", "Bram Stoker", 1897, "Horror"));
    }

    private void btnTitle_Click(object sender, EventArgs e)
    {
        string title = txtTitle.Text.Trim().ToLower();

        foreach (Book book in books)
        {
            // ToLower() on both sides makes the search ignore uppercase and lowercase.
            if (book.Title.ToLower() == title)
            {
                ShowBook(book);
                return;   // Found it, so stop searching.
            }
        }

        lblResult.Text = "";
        MessageBox.Show("No book has the title \"" + txtTitle.Text + "\".", "Not Found");
    }

    private void btnAuthor_Click(object sender, EventArgs e)
    {
        string author = txtAuthor.Text.Trim().ToLower();

        foreach (Book book in books)
        {
            if (book.Author.ToLower() == author)
            {
                ShowBook(book);
                return;
            }
        }

        lblResult.Text = "";
        MessageBox.Show("No book has the author \"" + txtAuthor.Text + "\".", "Not Found");
    }

    // Pressing Enter in the Title TextBox clicks the Search Title button.
    private void txtTitle_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            btnTitle.PerformClick();
            e.SuppressKeyPress = true;   // Stops the "ding" sound.
        }
    }

    // Pressing Enter in the Author TextBox clicks the Search Author button.
    private void txtAuthor_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            btnAuthor.PerformClick();
            e.SuppressKeyPress = true;
        }
    }

    private void ShowBook(Book book)
    {
        lblResult.Text = "Title: " + book.Title + "\n" +
                         "Author: " + book.Author + "\n" +
                         "Year: " + book.Year + "\n" +
                         "Genre: " + book.Genre;
    }
}
