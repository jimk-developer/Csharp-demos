// Demo 5 - Email Masker
// Concepts: a method with THREE parameters of different types (string, char, int)
//           that builds and RETURNS a new string; char.IsLetter() and char.IsDigit().

namespace Demo5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMask_Click(object sender, EventArgs e)
        {
            if (txtMaskChar.Text.Length != 1)
            {
                MessageBox.Show("Please enter exactly one mask character.");
                txtMaskChar.Focus();
                return;
            }

            if (!int.TryParse(txtNumToShow.Text, out int numToShow) || numToShow < 0)
            {
                MessageBox.Show("Please enter a whole number of 0 or more.");
                txtNumToShow.Focus();
                return;
            }

            // Three arguments, in the same order as the parameter list.
            string masked = MaskText(txtText.Text, txtMaskChar.Text[0], numToShow);

            lblResult.Text = masked;
        }

        /// <summary>
        /// Masks every letter and digit EXCEPT the first few, which are left visible.
        /// Any other character (@ . - _ spaces, etc.) is left exactly as it is.
        /// Works for text of any length - if the text is shorter than
        /// numCharsToShow, nothing gets masked.
        ///
        /// Example: MaskText("student42@college.edu", '*', 3)
        ///          returns "stu******@*******.***"
        ///
        /// Parameters: text to mask, the replacement character,
        ///             how many letters/digits to leave visible at the start
        /// Returns:    the masked string
        /// </summary>
        private string MaskText(string text, char replacementChar, int numCharsToShow)
        {
            string result = "";
            int charsShown = 0;     // how many letters/digits we've left visible so far

            foreach (char c in text)
            {
                if (char.IsLetter(c) || char.IsDigit(c))
                {
                    if (charsShown < numCharsToShow)
                    {
                        result += c;                // still in the "show" zone
                        charsShown++;
                    }
                    else
                    {
                        result += replacementChar;  // hide it
                    }
                }
                else
                {
                    result += c;                    // punctuation / spaces stay as-is
                }
            }

            return result;
        }
    }
}
