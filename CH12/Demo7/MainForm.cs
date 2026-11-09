namespace Demo7;

public partial class MainForm : Form
{
    private List<Team> teams = new List<Team>();

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        // Each team gets its own players.
        Team rockets = new Team("Rockets");
        rockets.AddPlayer(new Player(7, "Alex", "Rivera", "Guard"));
        rockets.AddPlayer(new Player(12, "Jordan", "Lee", "Forward"));
        rockets.AddPlayer(new Player(23, "Sam", "Patel", "Center"));
        rockets.AddPlayer(new Player(31, "Casey", "Brooks", "Guard"));

        Team comets = new Team("Comets");
        comets.AddPlayer(new Player(4, "Taylor", "Nguyen", "Guard"));
        comets.AddPlayer(new Player(9, "Morgan", "Diaz", "Forward"));
        comets.AddPlayer(new Player(15, "Riley", "Chen", "Center"));

        teams.Add(rockets);
        teams.Add(comets);

        foreach (Team team in teams)
        {
            cboTeams.Items.Add(team);
        }

        // Selecting the first team runs cboTeams_SelectedIndexChanged.
        cboTeams.SelectedIndex = 0;
    }

    private void cboTeams_SelectedIndexChanged(object sender, EventArgs e)
    {
        RefreshRoster();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        int number;
        if (!int.TryParse(txtNumber.Text, out number))
        {
            MessageBox.Show("Please enter a whole number for the jersey number.", "League Rosters");
            return;
        }

        // Add the player to whichever team is selected.
        Team team = teams[cboTeams.SelectedIndex];
        team.AddPlayer(new Player(number, txtFirstName.Text, txtLastName.Text, txtPosition.Text));

        txtNumber.Clear();
        txtFirstName.Clear();
        txtLastName.Clear();
        txtPosition.Clear();

        RefreshRoster();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        if (cboPlayers.SelectedIndex == -1)
        {
            MessageBox.Show("Please select a player to remove.", "League Rosters");
            return;
        }

        Team team = teams[cboTeams.SelectedIndex];
        Player player = team.Players[cboPlayers.SelectedIndex];
        team.RemovePlayer(player);

        RefreshRoster();
    }

    // Shows only the selected team's players.
    private void RefreshRoster()
    {
        Team team = teams[cboTeams.SelectedIndex];

        rtbRoster.Clear();
        cboPlayers.Items.Clear();

        rtbRoster.AppendText(team.Name + " Roster\n\n");

        foreach (Player player in team.Players)
        {
            rtbRoster.AppendText(player.ToString() + "\n");
            cboPlayers.Items.Add(player);
        }
    }
}
