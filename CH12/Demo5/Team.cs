namespace Demo5;

// A team has a name and a List of players.
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
}
