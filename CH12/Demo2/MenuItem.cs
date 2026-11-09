namespace Demo2;

// Holds all of the information about one item on the menu.
public class MenuItem
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Calories { get; set; }

    public MenuItem(string name, decimal price, int calories)
    {
        Name = name;
        Price = price;
        Calories = calories;
    }

    // This is the text the results ListBox shows for each item.
    public override string ToString()
    {
        return Name + " - " + Price.ToString("C") + " - " + Calories + " calories";
    }
}
