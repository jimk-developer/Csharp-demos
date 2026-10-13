namespace Demo2
{
    public partial class LibraryBooksForm : Form
    {
        // Staff must type this code to add, update, or delete
        string staffCode = "0000";

        const int MAX_BOOKS = 20;
        Book[] books = new Book[MAX_BOOKS];
        int bookCount = 0;

        public LibraryBooksForm()
        {
            InitializeComponent();

            books[0] = new Book("Charlotte's Web", 1001, 3);
            books[1] = new Book("Hatchet", 1002, 2);
            books[2] = new Book("The Giver", 1003, 4);
            books[3] = new Book("Holes", 1004, 1);
            books[4] = new Book("Wonder", 1005, 5);
            bookCount = 5;
        }

        // Returns the index of the book with this ID, or -1 if not found
        private int FindBookIndex(int bookId)
        {
            for (int i = 0; i < bookCount; i++)
            {
                if (books[i].GetBookId() == bookId)
                {
                    return i;
                }
            }
            return -1;
        }

        // Returns true if the staff code box matches staffCode
        private bool StaffCodeIsCorrect()
        {
            if (txtStaffCode.Text == staffCode)
            {
                return true;
            }
            lblMessage.Text = "Staff code incorrect";
            return false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtSearchId.Text);
            int index = FindBookIndex(bookId);

            if (index == -1)
            {
                lblBookInfo.Text = "Book not found";
            }
            else
            {
                Book book = books[index];
                lblBookInfo.Text = "Title: " + book.GetTitle() +
                                   "     ID: " + book.GetBookId() +
                                   "     Copies: " + book.GetCopies();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!StaffCodeIsCorrect()) return;

            string title = txtAddTitle.Text.Trim();
            int bookId = int.Parse(txtAddId.Text);
            int copies = int.Parse(txtAddCopies.Text);

            if (bookCount >= MAX_BOOKS)
            {
                lblMessage.Text = "The library is full (20 books).";
            }
            else if (FindBookIndex(bookId) != -1)
            {
                lblMessage.Text = "That ID is already used";
            }
            else
            {
                books[bookCount] = new Book(title, bookId, copies);
                bookCount++;
                lblMessage.Text = title + " was added.";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!StaffCodeIsCorrect()) return;

            int bookId = int.Parse(txtUpdateId.Text);
            int newCopies = int.Parse(txtUpdateCopies.Text);
            int index = FindBookIndex(bookId);

            if (index == -1)
            {
                lblMessage.Text = "Book not found";
            }
            else
            {
                // Use the SETTER to change the private field
                books[index].SetCopies(newCopies);
                lblMessage.Text = books[index].GetTitle() + " now has " + newCopies + " copies.";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!StaffCodeIsCorrect()) return;

            int bookId = int.Parse(txtDeleteId.Text);
            int index = FindBookIndex(bookId);

            if (index == -1)
            {
                lblMessage.Text = "Book not found";
            }
            else
            {
                string title = books[index].GetTitle();

                // Move the last book into the empty spot, then shrink the count
                books[index] = books[bookCount - 1];
                books[bookCount - 1] = null;
                bookCount--;

                lblMessage.Text = title + " was deleted.";
            }
        }
    }
}
