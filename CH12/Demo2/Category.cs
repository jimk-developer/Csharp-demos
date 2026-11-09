namespace Demo2;

// A menu category, such as Breakfast, and the items in it.
public class Category
{
    public string Name { get; set; }
    public MenuItem[] Items { get; set; }

    public Category(string name, MenuItem[] items)
    {
        Name = name;
        Items = items;
    }

    // This is the text the category ListBox shows.
    public override string ToString()
    {
        return Name;
    }
}
