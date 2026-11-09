namespace Demo7;

// A team has a name and its own List of players.
public class Team
{
    public string Name { get; set; }
    public List<Player> Players { get; set; } = new List<Player>();

    public Team(string name)
    {
        Name = name;
    }

    public void AddPlayer(Player p)
    {
        Players.Add(p);
    }

    public void RemovePlayer(Player p)
    {
        Players.Remove(p);
    }

    // This is the text the team ComboBox shows.
    public override string ToString()
    {
        return Name;
    }
}
