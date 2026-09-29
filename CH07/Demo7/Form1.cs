// Demo 7 - Campus Cafe Card
// Concepts: parallel Lists, a linear search, tracking the "active" record
//           with an index, and void methods that change the form's state.

namespace Demo7
{
    public partial class Form1 : Form
    {
        // Parallel Lists: the same index refers to the same student in every list.
        //   index 0 -> S1001 / 1234 / Maria Lopez  / $45.00
        private List<string> studentIds = new List<string> { "S1001", "S1002", "S1003" };
        private List<string> pins = new List<string> { "1234", "5678", "2468" };
        private List<string> names = new List<string> { "Maria Lopez", "Devon Carter", "Priya Patel" };
        private List<decimal> balances = new List<decimal> { 45.00m, 12.50m, 0.00m };

        // Index of the signed-in student. -1 means nobody is signed in.
        // Only ONE student can be signed in at a time.
        private int activeIndex = -1;

        public Form1()
        {
            InitializeComponent();
            SignOut();                          // start in the signed-out state
            lblMessage.Text = "Please sign in.";
        }

        // ---------- Event handlers: validate input, then call a method ----------

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignIn(txtStudentId.Text.Trim(), txtPin.Text.Trim());
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            SignOut();
        }

        private void btnAddFunds_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAddFunds.Text, out decimal amount) && amount > 0)
            {
                AddFunds(amount);
            }
            else
            {
                lblMessage.Text = "Enter an amount greater than $0.";
            }
            txtAddFunds.Clear();
        }

        private void btnBuyMeal_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMealPrice.Text, out decimal price) && price > 0)
            {
                BuyMeal(price);
            }
            else
            {
                lblMessage.Text = "Enter a meal price greater than $0.";
            }
            txtMealPrice.Clear();
        }

        // ------------------------------ Methods ------------------------------

        /// <summary>
        /// Signs a student in if the ID and PIN match. If they don't match,
        /// whoever was signed in is signed out and an error is shown.
        /// </summary>
        private void SignIn(string studentId, string pin)
        {
            int foundIndex = -1;

            // Linear search: check each position until a match is found.
            for (int i = 0; i < studentIds.Count; i++)
            {
                if (studentIds[i] == studentId && pins[i] == pin)
                {
                    foundIndex = i;
                    break;          // stop searching once we find it
                }
            }

            if (foundIndex != -1)
            {
                activeIndex = foundIndex;
                lblWelcome.Text = $"Welcome, {names[activeIndex]}!";
                ShowBalance();
                SetAccountControls(true);
                lblMessage.Text = "Signed in successfully.";
            }
            else
            {
                SignOut();      // make sure the previous student is signed out
                lblMessage.Text = "Invalid Student ID or PIN.";
            }

            txtPin.Clear();     // never leave a PIN sitting in the box
        }

        /// <summary>
        /// Signs out the active student and resets the form.
        /// </summary>
        private void SignOut()
        {
            activeIndex = -1;
            lblWelcome.Text = "";
            lblBalance.Text = "";
            txtAddFunds.Clear();
            txtMealPrice.Clear();
            SetAccountControls(false);
            lblMessage.Text = "You have been signed out.";
        }

        /// <summary>
        /// Adds money to the active student's card and shows the new balance.
        /// </summary>
        private void AddFunds(decimal amount)
        {
            if (activeIndex == -1)
            {
                lblMessage.Text = "Please sign in first.";
                return;
            }

            balances[activeIndex] += amount;
            ShowBalance();
            lblMessage.Text = $"Added {amount:C} to your card.";
        }

        /// <summary>
        /// Charges a meal to the active student's card if there is enough money.
        /// </summary>
        private void BuyMeal(decimal mealPrice)
        {
            if (activeIndex == -1)
            {
                lblMessage.Text = "Please sign in first.";
                return;
            }

            if (mealPrice > balances[activeIndex])
            {
                lblMessage.Text = "Insufficient funds for that meal.";
                return;
            }

            balances[activeIndex] -= mealPrice;
            ShowBalance();
            lblMessage.Text = $"Meal purchased for {mealPrice:C}. Enjoy!";
        }

        // ------------------------- Helper methods ---------------------------

        private void ShowBalance()
        {
            lblBalance.Text = $"Your card balance is {balances[activeIndex]:C}";
        }

        /// <summary>
        /// Turns the deposit/purchase/sign-out controls on or off.
        /// </summary>
        private void SetAccountControls(bool enabled)
        {
            txtAddFunds.Enabled = enabled;
            btnAddFunds.Enabled = enabled;
            txtMealPrice.Enabled = enabled;
            btnBuyMeal.Enabled = enabled;
            btnSignOut.Enabled = enabled;
        }
    }
}
