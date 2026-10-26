namespace Demo4;

// Relationships:
//   PlusMealCard IS-A MealCard (inheritance): it keeps every Basic feature,
//   and overrides only what changes (its tier name and the history perk).
public class PlusMealCard : MealCard
{
    public PlusMealCard(string studentId, string pin, string ownerName, decimal balance)
        : base(studentId, pin, ownerName, balance)
    {
    }

    public override string Tier
    {
        get { return "Plus"; }
    }

    public override bool CanViewHistory
    {
        get { return true; }
    }
}
