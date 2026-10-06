// Demo2. Title Case Converter
// Capitalizes the first letter of every word in a phrase and lowercases the rest.
// Concepts: array as a parameter, changing array elements inside a method,
//           String.Split(), String.Join(), Substring(), ToUpper() / ToLower().

namespace Demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Demo 2: CapitalizeWords()
        // Capitalizes the first letter of each word in the array and lowercases the rest.
        // Accepts an array of strings and returns void.
        //   words - the array of words to change. An array is passed as a reference
        //           to the SAME array, so the caller sees every change made here.
        private void CapitalizeWords(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                // First letter uppercase + the rest of the word lowercase.
                // (Split with RemoveEmptyEntries guarantees no word is empty.)
                words[i] = word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
            }
        }

        // The calling method: gathers and validates input, calls CapitalizeWords(),
        // then displays the changed array.
        private void btnCapitalize_Click(object sender, EventArgs e)
        {
            string phrase = txtPhrase.Text.Trim();

            if (phrase == "")
            {
                lblOutput.Text = "Please enter a phrase";
                txtPhrase.Focus();
                return;
            }

            // Break the phrase into words. RemoveEmptyEntries skips extra spaces.
            string[] words = phrase.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // No return value and no ref -- the method changes the array's elements directly.
            CapitalizeWords(words);

            // The same array now holds the capitalized words.
            lblOutput.Text = string.Join(" ", words);
        }
    }
}
