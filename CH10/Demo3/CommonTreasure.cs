namespace Demo3;

// Relationships:
//   CommonTreasure IMPLEMENTS ITreasure (and so also IComparable<ITreasure>).
//   CommonTreasure USES a Label (dependency): it only borrows the label to draw on it.
public class CommonTreasure : ITreasure
{
    private string _name;
    private decimal _value;

    public CommonTreasure(string name, decimal value)
    {
        _name = name;
        _value = value;
    }

    public string Name
    {
        get { return _name; }
    }

    public decimal Value
    {
        get { return _value; }
    }

    // Plain look: regular font, black on white.
    public void ShowTreasure(Label label)
    {
        label.Text = $"{Name}   {Value:C}";
        label.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
        label.ForeColor = Color.Black;
        label.BackColor = Color.White;
    }

    // Highest value first: compare the OTHER value to this one (swap them for lowest first).
    public int CompareTo(ITreasure? other)
    {
        if (other == null)
        {
            return -1;
        }
        return other.Value.CompareTo(Value);
    }
}
