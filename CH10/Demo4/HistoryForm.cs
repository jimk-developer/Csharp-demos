namespace Demo4;

// Relationships:
//   HistoryForm IS-A Form (inheritance).
//   HistoryForm USES a List<string> (dependency): it only displays the lines it is given,
//   and knows nothing about MealCard, so any card tier can use it.
public partial class HistoryForm : Form
{
    public HistoryForm(List<string> lines)
    {
        InitializeComponent();

        if (lines.Count == 0)
        {
            lstHistory.Items.Add("No transactions yet.");
            return;
        }

        foreach (string line in lines)
        {
            lstHistory.Items.Add(line);
        }
    }
}
