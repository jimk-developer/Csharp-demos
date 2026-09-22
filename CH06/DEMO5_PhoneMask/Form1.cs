using System;
using System.Windows.Forms;

namespace DEMO5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMask_Click(object sender, EventArgs e)
        {
            // GOAL: hide every letter and digit EXCEPT the last 3 characters.
            //       Spaces, dashes, dots, and parentheses are never hidden.
            //
            //       (314) 555-8842   ->   (***) ***-*842
            //       314.555.8842     ->   ***.***.*842
            //       3145558842       ->   *******842
            //       555-CALL-NOW     ->   ***-****-NOW
            //       55               ->   55            (too short to hide)

            string input = txtPhone.Text;

            // A string can be read one character at a time with a subscript:
            //     string name = "Bob";
            //     char letter = name[0];   // letter is 'B'
            //     char letter2 = name[1];  // letter2 is 'o'

            // maskedPhone is an ACCUMULATOR. It starts empty and we glue one
            // character onto the end of it each time through the loop.
            string maskedPhone = "";

            // The last 3 characters start at this position.
            int keepFrom = input.Length - 3;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (i >= keepFrom)
                {
                    // We are in the last 3 characters - leave them alone.
                    maskedPhone = maskedPhone + currentChar;
                }
                else if (Char.IsDigit(currentChar) || Char.IsLetter(currentChar))
                {
                    // A number or a letter gets hidden.
                    maskedPhone = maskedPhone + "*";
                }
                else
                {
                    // Anything else (space, dash, dot, parenthesis) stays.
                    maskedPhone = maskedPhone + currentChar;
                }
            }

            lblMasked.Text = maskedPhone;
        }
    }
}
