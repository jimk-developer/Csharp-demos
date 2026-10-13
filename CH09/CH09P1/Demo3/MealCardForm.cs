namespace Demo3
{
    public partial class MealCardForm : Form
    {
        MealCard[] cards = new MealCard[5];

        // The card that is signed in right now (null = nobody)
        MealCard currentCard = null;

        public MealCardForm()
        {
            InitializeComponent();

            cards[0] = new MealCard("1001", "1111", "Ava Brooks", 20.00m);
            cards[1] = new MealCard("1002", "2222", "Liam Carter", 5.50m);
            cards[2] = new MealCard("1003", "3333", "Mia Evans", 12.25m);
            cards[3] = new MealCard("1004", "4444", "Noah Foster", 0.00m);
            cards[4] = new MealCard("1005", "5555", "Zoe Grant", 40.00m);
        }

        // ---------- Form methods ----------

        private void SignIn(string cardNumber, string pin)
        {
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i].GetCardNumber() == cardNumber && cards[i].GetPin() == pin)
                {
                    currentCard = cards[i];
                    lblWelcome.Text = "Welcome, " + currentCard.GetStudentName();
                    ShowBalance();
                    lblMessage.Text = "";
                    return;
                }
            }

            // No match: sign out whoever was signed in
            SignOut();
            lblMessage.Text = "Invalid card number or PIN";
        }

        private void SignOut()
        {
            currentCard = null;
            lblWelcome.Text = "";
            lblBalance.Text = "";
            lblMessage.Text = "";
            txtCardNumber.Clear();
            txtPin.Clear();
            txtAmount.Clear();
        }

        private void AddMoney(decimal amount)
        {
            if (currentCard == null)
            {
                lblMessage.Text = "Please sign in first";
                return;
            }

            currentCard.AddFunds(amount);
            ShowBalance();
            lblMessage.Text = "Added " + amount.ToString("C");
        }

        private void PayForMeal(decimal amount)
        {
            if (currentCard == null)
            {
                lblMessage.Text = "Please sign in first";
                return;
            }

            // BuyMeal returns true or false
            if (currentCard.BuyMeal(amount))
            {
                ShowBalance();
                lblMessage.Text = "Meal purchased for " + amount.ToString("C");
            }
            else
            {
                lblMessage.Text = "Not enough money on card";
            }
        }

        private void ShowBalance()
        {
            lblBalance.Text = "Balance: " + currentCard.GetBalance().ToString("C");
        }

        // ---------- Button clicks ----------

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignIn(txtCardNumber.Text.Trim(), txtPin.Text.Trim());
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            SignOut();
            lblMessage.Text = "Signed out";
        }

        private void btnAddFunds_Click(object sender, EventArgs e)
        {
            AddMoney(decimal.Parse(txtAmount.Text));
        }

        private void btnBuyMeal_Click(object sender, EventArgs e)
        {
            PayForMeal(decimal.Parse(txtAmount.Text));
        }
    }
}
