namespace Demo6;

// A team has a name and a Dictionary of players.
// The key is the jersey number, so each number can be used only once.
public class Team
{
    public string Name { get; set; }
    public Dictionary<int, Player> Players { get; set; } = new Dictionary<int, Player>();

    public Team(string name)
    {
        Name = name;
    }

    // Returns false if the jersey number is already taken.
    public bool AddPlayer(Player p)
    {
        if (Players.ContainsKey(p.Number))
        {
            return false;
        }

        Players.Add(p.Number, p);
        return true;
    }

    public void RemovePlayer(int number)
    {
        Players.Remove(number);
    }

    // Returns the player with this number, or null if there is none.
    public Player? FindPlayer(int number)
    {
        if (Players.ContainsKey(number))
        {
            return Players[number];
        }

        return null;
    }
}
