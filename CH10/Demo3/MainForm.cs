namespace Demo3;

// Relationships:
//   MainForm IS-A Form (inheritance).
//   MainForm OWNS one Random and the catalog arrays (composition).
//   The chest List<ITreasure> HAS treasures (aggregation); each item is a CommonTreasure or a RareTreasure.
//   MainForm USES CommonTreasure and RareTreasure (dependency) but only talks to them through ITreasure.
public partial class MainForm : Form
{
    private const int ChestSize = 5;
    private const int RareChancePercent = 25;

    // Treasure catalog: names[i] goes with values[i].
    private readonly string[] _names = { "Copper Coin", "Silver Ring", "Pearl", "Ruby", "Ancient Map", "Gold Bar" };
    private readonly decimal[] _values = { 1.00m, 15.00m, 25.00m, 40.00m, 60.00m, 100.00m };

    // One Random for the whole form (not a new one per click).
    private readonly Random _random = new Random();

    public MainForm()
    {
        InitializeComponent();
    }

    private void btnOpenChest_Click(object? sender, EventArgs e)
    {
        // The list's type is the interface, so it can hold both classes.
        List<ITreasure> chest = new List<ITreasure>();

        for (int i = 0; i < ChestSize; i++)
        {
            int pick = _random.Next(_names.Length);

            if (_random.Next(100) < RareChancePercent)
            {
                chest.Add(new RareTreasure(_names[pick], _values[pick]));
            }
            else
            {
                chest.Add(new CommonTreasure(_names[pick], _values[pick]));
            }
        }

        // Sort() calls each item's CompareTo (from IComparable<ITreasure>).
        chest.Sort();

        Label[] slots = { lblSlot1, lblSlot2, lblSlot3, lblSlot4, lblSlot5 };
        decimal total = 0;

        for (int i = 0; i < chest.Count; i++)
        {
            // Polymorphism: the form never checks the type; each treasure draws itself.
            chest[i].ShowTreasure(slots[i]);
            total += chest[i].Value;
        }

        lblTotal.Text = $"Chest value: {total:C}";
    }
}
