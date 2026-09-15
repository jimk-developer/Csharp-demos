// ---------------------------------------------------------------------------
// Demo 5 - Punctuation Counter (WinForms)
// Chapter 5 demo: walking a string with a definite loop and a switch structure
//
// The UI is one label, one text box, one button, and four result labels -
// the same controls used in the Chapter 5 labs.
//
// Concepts on display:
//   - a definite loop whose limit is the string's Length
//   - String.Substring(i, 1) to pull out one character position at a time
//   - a switch structure with one case per punctuation mark
//   - GROUPED (stacked) case labels sharing one block of code, in the
//     whitespace branch
//   - the default case as the catch-all, counted and reported like the rest
//
// Part of the Demo5 project. Open Demo5.slnx in Visual Studio and press F5.
// ---------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demo5;

public partial class PunctuationForm : Form
{
    public PunctuationForm()
    {
        InitializeComponent();
    }

    private void btnEnter_Click(object sender, EventArgs e)
    {
        string phrase = txtPhrase.Text;

        // ---- Individual counters --------------------------------------------
        int periods = 0, exclamations = 0, questions = 0;
        int commas = 0, semicolons = 0, colons = 0;
        int whitespace = 0, other = 0;

        // ---- The loop: one iteration per character position ------------------
        // Length is the number of characters, and positions run 0 through
        // Length - 1, which is why the test is "<" and not "<=".
        for (int i = 0; i < phrase.Length; i++)
        {
            // Substring(startPosition, howMany) - one character, as a string.
            string ch = phrase.Substring(i, 1);

            switch (ch)
            {
                // Sentence-ending marks. Each gets its own case because we
                // report each one individually.
                case ".":
                    periods++;
                    break;

                case "!":
                    exclamations++;
                    break;

                case "?":
                    questions++;
                    break;

                // Separators.
                case ",":
                    commas++;
                    break;

                case ";":
                    semicolons++;
                    break;

                case ":":
                    colons++;
                    break;

                // GROUPED CASES: stacked labels with one block of code, so a
                // space and a tab are counted the same way. This is the only
                // way to "fall through" in C# - a case with statements in it
                // cannot fall into the next one.
                case " ":
                case "\t":
                    whitespace++;
                    break;

                // Everything else: letters, digits, and anything unusual.
                default:
                    other++;
                    break;
            }
        }

        // ---- Subtotals are just sums of the counters ------------------------
        int endingTotal = periods + exclamations + questions;
        int separatorTotal = commas + semicolons + colons;

        // ---- Report: four labels, no boxes or grids -------------------------
        lblEnding.Text = $"Sentence-ending marks: {endingTotal}   "
                       + $"( . = {periods}   ! = {exclamations}   ? = {questions} )";

        lblSeparators.Text = $"Separators: {separatorTotal}   "
                           + $"( , = {commas}   ; = {semicolons}   : = {colons} )";

        lblOther.Text = $"Not punctuation: {other} other characters, {whitespace} spaces";

        lblTotal.Text = $"There are {endingTotal + separatorTotal} punctuation marks in your phrase";
    }
}
