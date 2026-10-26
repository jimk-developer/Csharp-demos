namespace Demo4;

// Relationships:
//   PremiumMealCard IS-A PlusMealCard, which IS-A MealCard (multi-level inheritance).
//   It inherits CanViewHistory = true from PlusMealCard without writing it again.
public class PremiumMealCard : PlusMealCard
{
    public PremiumMealCard(string studentId, string pin, string ownerName, decimal balance)
        : base(studentId, pin, ownerName, balance)
    {
    }

    public override string Tier
    {
        get { return "Premium"; }
    }

    // No convenience fee for Premium cards.
    public override decimal FeeRate
    {
        get { return 0m; }
    }

    // Reuse the base "last 5" list with base.GetHistory(), then wrap it as a receipt.
    public override List<string> GetHistory()
    {
        List<string> lines = new List<string>();
        lines.Add("===== RANKEN MEAL CARD STATEMENT =====");
        lines.Add($"{_ownerName}  |  {Tier}");
        lines.AddRange(base.GetHistory());
        lines.Add($"Current balance: {_balance:C}");
        lines.Add("======================================");
        return lines;
    }
}
