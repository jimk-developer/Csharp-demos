namespace Demo4;

// Relationships:
//   MainForm IS-A Form (inheritance).
//   MainForm OWNS its List<MealCard> (composition); the list HAS the card objects (aggregation).
//   _current HAS-A reference to one card at a time (association); it may point to any tier (polymorphism).
//   MainForm USES HistoryForm (dependency): it creates one only when needed and closes it after.
public partial class MainForm : Form
{
    private readonly List<MealCard> _cards = new List<MealCard>();

    // The logged-in card; null means nobody is logged in.
    private MealCard? _current;

    public MainForm()
    {
        InitializeComponent();

        // A List<MealCard> can store subclass objects too.
        _cards.Add(new MealCard("1001", "1111", "Ava Lopez", 25.00m));
        _cards.Add(new PlusMealCard("1002", "2222", "Ben Carter", 50.00m));
        _cards.Add(new PremiumMealCard("1003", "3333", "Chloe Nguyen", 100.00m));

        ShowLoggedIn(false);
    }

    private void btnLogin_Click(object? sender, EventArgs e)
    {
        string id = txtStudentId.Text.Trim();
        string pin = txtPin.Text.Trim();

        foreach (MealCard card in _cards)
        {
            if (card.StudentId == id && card.CheckPin(pin))
            {
                _current = card;
                break;
            }
        }

        if (_current == null)
        {
            MessageBox.Show("Student ID or PIN is incorrect.", "Login Failed");
            txtPin.Clear();
            return;
        }

        ShowLoggedIn(true);
    }

    private void btnAddFunds_Click(object? sender, EventArgs e)
    {
        if (_current == null || !TryGetAmount(out decimal amount))
        {
            return;
        }

        _current.AddFunds(amount);
        RefreshCardInfo();
    }

    private void btnPurchase_Click(object? sender, EventArgs e)
    {
        if (_current == null || !TryGetAmount(out decimal amount))
        {
            return;
        }

        // Purchase uses the card's own FeeRate (2% or 0%), so no tier check is needed here.
        if (!_current.Purchase(amount))
        {
            MessageBox.Show("Not enough funds for this purchase and its fee.", "Purchase Refused");
            return;
        }

        RefreshCardInfo();
    }

    private void btnViewHistory_Click(object? sender, EventArgs e)
    {
        if (_current == null || !_current.CanViewHistory)
        {
            return;
        }

        // Plus shows a plain list; Premium's override shows a receipt. Same call either way.
        using HistoryForm history = new HistoryForm(_current.GetHistory());
        history.ShowDialog(this);
    }

    private void btnLogout_Click(object? sender, EventArgs e)
    {
        _current = null;
        ShowLoggedIn(false);
    }

    // Only one card at a time: login controls are off while someone is logged in.
    private void ShowLoggedIn(bool loggedIn)
    {
        txtStudentId.Enabled = !loggedIn;
        txtPin.Enabled = !loggedIn;
        btnLogin.Enabled = !loggedIn;

        txtAmount.Enabled = loggedIn;
        btnAddFunds.Enabled = loggedIn;
        btnPurchase.Enabled = loggedIn;
        btnLogout.Enabled = loggedIn;
        btnViewHistory.Visible = loggedIn && _current != null && _current.CanViewHistory;

        if (loggedIn)
        {
            RefreshCardInfo();
            txtAmount.Focus();
        }
        else
        {
            txtStudentId.Clear();
            txtPin.Clear();
            txtAmount.Clear();
            lblWelcome.Text = "Please log in.";
            lblBalance.Text = "";
            lblTier.Text = "";
            txtStudentId.Focus();
        }
    }

    private void RefreshCardInfo()
    {
        if (_current == null)
        {
            return;
        }

        lblWelcome.Text = $"Welcome, {_current.OwnerName}!";
        lblBalance.Text = $"Balance: {_current.Balance:C}";
        lblTier.Text = $"Card tier: {_current.Tier}";
        txtAmount.Clear();
    }

    private bool TryGetAmount(out decimal amount)
    {
        if (!decimal.TryParse(txtAmount.Text, out amount) || amount <= 0)
        {
            MessageBox.Show("Enter an amount greater than $0.00.", "Invalid Amount");
            return false;
        }
        return true;
    }
}
