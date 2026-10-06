// Demo3. Shipping Weight Checker
// Accepts a package weight in several formats and reports whether it can be shipped.
// Concepts: string parameter, string return type, String class methods,
//           double.TryParse(), range checks, formatting with ToString("F2").

namespace Demo3
{
    public partial class Form1 : Form
    {
        private const double MAX_WEIGHT = 70.0;   // heaviest package allowed, in lbs

        public Form1()
        {
            InitializeComponent();
        }

        // Demo 3: ParseWeight()
        // Parses a weight string and returns a message saying whether it was accepted.
        // Accepts a string for the weight and returns a string message.
        //   weightString - what the user typed, such as "12", "12.5 lbs" or "12 pounds"
        //   returns      - the message to display
        private string ParseWeight(string weightString)
        {
            string message;
            double weight;

            // Ignore spaces before/after and capitalization ("12.5 LBS" -> "12.5 lbs").
            string number = weightString.Trim().ToLower();

            // Remove an accepted unit ending, if there is one.
            // Check "lbs" before "lb" so the longer ending is removed first.
            if (number.EndsWith("pounds"))
            {
                number = number.Remove(number.Length - "pounds".Length);
            }
            else if (number.EndsWith("lbs"))
            {
                number = number.Remove(number.Length - "lbs".Length);
            }
            else if (number.EndsWith("lb"))
            {
                number = number.Remove(number.Length - "lb".Length);
            }

            // Allow either "12 lb" or "12lb".
            number = number.Trim();

            // What is left must be only digits and a decimal point ("12", "12.5", "12.50").
            // This rejects entries such as "12 kg", "-5" or "1,000".
            bool onlyDigits = number.Length > 0;
            foreach (char ch in number)
            {
                if (!char.IsDigit(ch) && ch != '.')
                {
                    onlyDigits = false;
                }
            }

            if (!onlyDigits || !double.TryParse(number, out weight))
            {
                message = "Invalid Weight";
            }
            else if (weight <= 0)
            {
                message = "Weight must be greater than 0 lbs";
            }
            else if (weight > MAX_WEIGHT)
            {
                message = "Package exceeds the " + MAX_WEIGHT + " lb limit";
            }
            else
            {
                message = "Package of " + weight.ToString("F2") + " lbs accepted!";
            }

            return message; // return output message
        }

        // The calling method: passes the text to ParseWeight() and displays
        // the string it returns. All of the checking happens in the method.
        private void btnCheckWeight_Click(object sender, EventArgs e)
        {
            lblMessage.Text = ParseWeight(txtWeight.Text);

            txtWeight.SelectAll();
            txtWeight.Focus();
        }
    }
}
