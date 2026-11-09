namespace Demo7;

// Holds all of the information about one player.
public class Player
{
    public int Number { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }

    public Player(int number, string firstName, string lastName, string position)
    {
        Number = number;
        FirstName = firstName;
        LastName = lastName;
        Position = position;
    }

    // Example: #7 Alex Rivera (Guard)
    public override string ToString()
    {
        return "#" + Number + " " + FirstName + " " + LastName + " (" + Position + ")";
    }
}
