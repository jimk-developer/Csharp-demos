namespace Demo4;

// Relationships:
//   MealCard IS-A System.Object.
//   MealCard is the BASE CLASS of PlusMealCard (and, through it, PremiumMealCard).
//   MealCard OWNS its _history list (composition): created in the constructor, lives and dies with the card.
//   This class is also the "Basic" tier.
public class MealCard
{
    protected string _studentId;
    protected string _pin;
    protected string _ownerName;
    protected decimal _balance;
    protected List<string> _history;

    public MealCard(string studentId, string pin, string ownerName, decimal balance)
    {
        _studentId = studentId;
        _pin = pin;
        _ownerName = ownerName;
        _balance = balance;
        _history = new List<string>();
    }

    public string StudentId
    {
        get { return _studentId; }
    }

    public string OwnerName
    {
        get { return _ownerName; }
    }

    public decimal Balance
    {
        get { return _balance; }
    }

    // The three virtual properties below are what each tier changes.
    public virtual string Tier
    {
        get { return "Basic"; }
    }

    public virtual decimal FeeRate
    {
        get { return 0.02m; }   // 2% convenience fee
    }

    public virtual bool CanViewHistory
    {
        get { return false; }
    }

    // The PIN stays private to the card (encapsulation); the form can only ask "is this right?"
    public bool CheckPin(string pin)
    {
        return pin == _pin;
    }

    // Adding funds never has a fee.
    public void AddFunds(decimal amount)
    {
        _balance += amount;
        _history.Add($"ADD {amount:C}");
    }

    // Written once, but reads the virtual FeeRate, so a Premium card pays $0 without its own Purchase().
    public bool Purchase(decimal amount)
    {
        decimal fee = Math.Round(amount * FeeRate, 2, MidpointRounding.AwayFromZero);

        if (amount + fee > _balance)
        {
            return false;   // would go below $0.00
        }

        _balance -= amount + fee;
        _history.Add($"PURCHASE {amount:C} (fee {fee:C})");
        return true;
    }

    // Returns the last 5 transactions (or fewer if there aren't 5 yet).
    public virtual List<string> GetHistory()
    {
        int count = Math.Min(5, _history.Count);
        return _history.GetRange(_history.Count - count, count);
    }
}
