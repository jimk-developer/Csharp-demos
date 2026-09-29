// Demo 3 - Letter Counter
// Concepts: a method that accepts a string and a char and RETURNS an int,
//           treating a string like an array of characters, an accumulator.

namespace Demo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            // Make sure exactly one letter was entered.
            if (txtLetter.Text.Length != 1 || !char.IsLetter(txtLetter.Text[0]))
            {
                MessageBox.Show("Please enter a single letter to count.");
                txtLetter.Focus();
                return;
            }

            string phrase = txtPhrase.Text;
            char letter = txtLetter.Text[0];   // first (and only) character

            // Call the method and capture the int it returns.
            int count = CountLetter(phrase, letter);

            lblResult.Text = $"The letter '{letter}' appears {count} time(s).";
        }

        /// <summary>
        /// Counts how many times a letter appears in a phrase.
        /// Upper and lowercase are treated the same ('S' matches 's').
        /// Parameters: phrase (string), letter (char)
        /// Returns:    the number of matches (int)
        /// </summary>
        private int CountLetter(string phrase, char letter)
        {
            int count = 0;                          // accumulator
            char target = char.ToLower(letter);     // compare everything in lowercase

            // A string can be indexed just like an array: phrase[0], phrase[1], ...
            for (int i = 0; i < phrase.Length; i++)
            {
                if (char.ToLower(phrase[i]) == target)
                {
                    count++;
                }
            }

            // The same loop written with foreach:
            // foreach (char c in phrase)
            // {
            //     if (char.ToLower(c) == target) count++;
            // }

            return count;
        }
    }
}
