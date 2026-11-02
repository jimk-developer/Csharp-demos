using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Demo3
{
    public partial class LibraryForm : Form
    {
        private List<Book> _books = new List<Book>();

        public LibraryForm()
        {
            InitializeComponent();

            _books.Add(new Book("B100", "Charlotte's Web", false));
            _books.Add(new Book("B200", "Hatchet", true));
            _books.Add(new Book("B300", "Holes", false));
        }

        // Returns the book if it can be checked out; otherwise throws an exception.
        public Book Checkout(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                throw new NoBookCodeException();
            }

            foreach (Book book in _books)
            {
                if (book.Code == code.Trim().ToUpper())
                {
                    if (book.IsCheckedOut)
                    {
                        throw new BookCheckedOutException();
                    }

                    book.IsCheckedOut = true;
                    return book;
                }
            }

            // We looked at every book and none matched.
            throw new BookNotFoundException();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = Checkout(txtCode.Text);

                lblResult.ForeColor = Color.Black;
                lblResult.Text = "Enjoy " + book.Title + "!";
            }
            catch (NoBookCodeException ex)
            {
                ShowError(ex.Message);
            }
            catch (BookNotFoundException ex)
            {
                ShowError(ex.Message);
            }
            catch (BookCheckedOutException ex)
            {
                ShowError(ex.Message);
            }
            finally
            {
                // The finally block runs whether or not an exception was thrown.
                txtCode.Clear();
                txtCode.Focus();
            }
        }

        private void ShowError(string message)
        {
            lblResult.ForeColor = Color.Red;
            lblResult.Text = message;
        }
    }
}
