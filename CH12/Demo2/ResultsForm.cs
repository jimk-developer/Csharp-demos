namespace Demo2;

public partial class ResultsForm : Form
{
    // MainForm passes in the items to show.
    public ResultsForm(List<MenuItem> items)
    {
        InitializeComponent();

        // Fill the results ListBox in code.
        foreach (MenuItem item in items)
        {
            lstResults.Items.Add(item);
        }
    }
}
