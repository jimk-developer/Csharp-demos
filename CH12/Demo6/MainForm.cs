namespace Demo6;

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
            MessageBox.Show("Please enter a whole number for the jersey number.", "Team Dictionary");
            return;
        }

        Player player = new Player(number, txtFirstName.Text, txtLastName.Text, txtPosition.Text);

        if (team.AddPlayer(player) == false)
        {
            MessageBox.Show("Jersey number " + number + " is already taken.", "Team Dictionary");
            return;
        }

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
            MessageBox.Show("Please select a jersey number to remove.", "Team Dictionary");
            return;
        }

        // The ComboBox holds jersey numbers, which are the Dictionary keys.
        int number = int.Parse(cboRemove.Text);
        team.RemovePlayer(number);

        RefreshRoster();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        int number;
        if (!int.TryParse(txtSearch.Text, out number))
        {
            lblSearchResult.Text = "Please enter a whole number.";
            return;
        }

        // The ? means this variable is allowed to hold null.
        Player? player = team.FindPlayer(number);

        if (player == null)
        {
            lblSearchResult.Text = "No player wears #" + number + ".";
        }
        else
        {
            lblSearchResult.Text = "Found: " + player.ToString();
        }
    }

    // Shows the current players in the RichTextBox and their numbers in the ComboBox.
    private void RefreshRoster()
    {
        rtbRoster.Clear();
        cboRemove.Items.Clear();

        rtbRoster.AppendText(team.Name + " Roster\n\n");

        // .Values gives just the Player objects from the Dictionary.
        foreach (Player player in team.Players.Values)
        {
            rtbRoster.AppendText(player.ToString() + "\n");
            cboRemove.Items.Add(player.Number);
        }
    }
}
