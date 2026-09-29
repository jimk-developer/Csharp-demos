// Demo 1 - Lunch Special Picker
// Concepts: class-level array, Random, a void method with NO parameters,
//           calling (invoking) a method from an event handler.

namespace Demo1
{
    public partial class Form1 : Form
    {
        // Class-level array (initializer list). Declared outside of any method,
        // so every method in this form can use it.
        private string[] lunchSpecials =
        {
            "Chicken Quesadilla with Rice",
            "Tomato Basil Soup & Grilled Cheese",
            "BBQ Pulled Pork Sandwich",
            "Veggie Stir Fry with Noodles",
            "Spaghetti and Meatballs",
            "Turkey Club Wrap with Chips",
            "Chili Cheese Baked Potato",
            "Caesar Salad with Grilled Chicken"
        };

        // One Random object for the whole form. Creating a new Random every
        // click can produce repeated values, so we create it once here.
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            // btnPick_Click is the CALLING method.
            // ShowDailySpecials is the CALLED method.
            // No arguments are passed, and nothing comes back.
            ShowDailySpecials();
        }

        /// <summary>
        /// Picks two DIFFERENT random lunch specials from the array
        /// and displays them on the form.
        /// Parameters: none       Returns: nothing (void)
        /// </summary>
        private void ShowDailySpecials()
        {
            // Local variables - they only exist inside this method (scope).
            // Next(n) returns a number from 0 up to (but not including) n,
            // which is exactly the range of valid array indexes.
            int firstIndex = random.Next(lunchSpecials.Length);
            int secondIndex;

            // Indefinite loop: keep picking until the second index is
            // different from the first, so the same special isn't shown twice.
            do
            {
                secondIndex = random.Next(lunchSpecials.Length);
            } while (secondIndex == firstIndex);

            lblSpecial1.Text = "Special #1: " + lunchSpecials[firstIndex];
            lblSpecial2.Text = "Special #2: " + lunchSpecials[secondIndex];
        }
    }
}
