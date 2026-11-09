namespace Demo5;

public partial class MainForm : Form
{
    private Team team = new Team("Rockets");

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        team.AddPlayer(new Player(7, "Alex", "Rivera", "Guard"));
        team.AddPlayer(new Player(12, "Jordan", "Lee", "Forward"));
        team.AddPlayer(new Player(23, "Sam", "Patel", "Center"));
        team.AddPlayer(new Player(31, "Casey", "Brooks", "Guard"));

        RefreshRoster();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        int number;
        if (!int.TryParse(txtNumber.Text, out number))
        {
            MessageBox.Show("Please enter a whole number for the jersey number.", "Team Roster");
            return;
        }

        Player player = new Player(number, txtFirstName.Text, txtLastName.Text, txtPosition.Text);
        team.AddPlayer(player);

        // Clear the TextBoxes for the next player.
        txtNumber.Clear();
        txtFirstName.Clear();
        txtLastName.Clear();
        txtPosition.Clear();

        RefreshRoster();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        if (cboRemove.SelectedIndex == -1)
        {
            MessageBox.Show("Please select a player to remove.", "Team Roster");
            return;
        }

        // The ComboBox items are in the same order as the List.
        Player player = team.Players[cboRemove.SelectedIndex];
        team.RemovePlayer(player);

        RefreshRoster();
    }

    // Shows the current players in the RichTextBox and the ComboBox.
    private void RefreshRoster()
    {
        rtbRoster.Clear();
        cboRemove.Items.Clear();

        rtbRoster.AppendText(team.Name + " Roster\n\n");

        foreach (Player player in team.Players)
        {
            rtbRoster.AppendText(player.ToString() + "\n");
            cboRemove.Items.Add(player);
        }
    }
}
