using System;
using System.Windows.Forms;

namespace DEMO3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // ---- THREE PARALLEL ARRAYS -------------------------------------
            // titles[2], authors[2], and prices[2] all describe the SAME book.
            string[] titles = { "The Silent Patient",
                                "Project Hail Mary",
                                "The Martian",
                                "Educated",
                                "Where the Crawdads Sing",
                                "A Brief History of Time" };

            string[] authors = { "Alex Michaelides",
                                 "Andy Weir",
                                 "Andy Weir",
                                 "Tara Westover",
                                 "Delia Owens",
                                 "Stephen Hawking" };

            double[] prices = { 16.99, 18.50, 12.99, 14.25, 15.75, 11.00 };

            // ---- BUILD THE SEARCH KEY --------------------------------------
            // ToLower() on BOTH sides is what makes the search case insensitive.
            string keyword = txtSearch.Text.Trim().ToLower();

            if (keyword == "")
            {
                lblTitleOut.Text = "";
                lblAuthorOut.Text = "";
                lblPriceOut.Text = "";
                lblMessage.Text = "Type part of a title or an author, then click Search.";
                return;
            }

            // ---- LINEAR SEARCH WITH A PARTIAL MATCH ------------------------
            // Contains() returns true when the keyword appears ANYWHERE inside
            // the text, so "wei" matches "Andy Weir" and "mar" matches
            // "The Martian".
            bool found = false;
            int foundIndex = -1;       // -1 means "nothing found yet"

            for (int i = 0; i < titles.Length; i++)
            {
                string titleLower = titles[i].ToLower();
                string authorLower = authors[i].ToLower();

                if (titleLower.Contains(keyword) || authorLower.Contains(keyword))
                {
                    found = true;
                    foundIndex = i;
                    break;             // stop at the FIRST match
                }
            }

            // ---- DISPLAY THE RESULT ----------------------------------------
            if (found)
            {
                lblTitleOut.Text = titles[foundIndex];
                lblAuthorOut.Text = authors[foundIndex];
                lblPriceOut.Text = prices[foundIndex].ToString("C");
                lblMessage.Text = "";
            }
            else
            {
                lblTitleOut.Text = "Book Not Found";
                lblAuthorOut.Text = "Book Not Found";
                lblPriceOut.Text = "Book Not Found";
                lblMessage.Text = "No book matched \"" + txtSearch.Text.Trim() + "\".";
            }
        }
    }
}
