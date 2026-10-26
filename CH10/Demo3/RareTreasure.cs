namespace Demo3;

// Relationships:
//   RareTreasure IMPLEMENTS ITreasure (and so also IComparable<ITreasure>).
//   RareTreasure OWNS its Font (composition): it creates the Font itself, and the Font lives with it.
//   RareTreasure HAS-A foreground and background Color.
//   RareTreasure USES a Label (dependency) to show itself.
public class RareTreasure : ITreasure
{
    private string _name;
    private decimal _baseValue;
    private Font _font;
    private Color _foreColor;
    private Color _backColor;

    public RareTreasure(string name, decimal baseValue)
    {
        _name = name;
        _baseValue = baseValue;

        // Rare look, set once here.
        _font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
        _foreColor = Color.Gold;
        _backColor = Color.FromArgb(40, 40, 60);
    }

    public string Name
    {
        get { return $"★ {_name} (Rare)"; }
    }

    // A rare treasure is worth 3 times its catalog value.
    public decimal Value
    {
        get { return _baseValue * 3; }
    }

    public void ShowTreasure(Label label)
    {
        label.Text = $"{Name}   {Value:C}";
        label.Font = _font;
        label.ForeColor = _foreColor;
        label.BackColor = _backColor;
    }

    // Same rule as CommonTreasure, so common and rare items sort together.
    public int CompareTo(ITreasure? other)
    {
        if (other == null)
        {
            return -1;
        }
        return other.Value.CompareTo(Value);
    }
}
