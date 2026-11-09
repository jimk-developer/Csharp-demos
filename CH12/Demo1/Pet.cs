namespace Demo1;

// Holds all of the information about one pet.
public class Pet
{
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
    public string Description { get; set; }

    public Pet(string name, string species, int age, string description)
    {
        Name = name;
        Species = species;
        Age = age;
        Description = description;
    }

    // The ComboBox calls ToString() to decide what text to show for each pet.
    public override string ToString()
    {
        return Name;
    }
}
