namespace Demo1;

public partial class MainForm : Form
{
    private List<Pet> pets = new List<Pet>();

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        // Create the pets.
        pets.Add(new Pet("Biscuit", "Dog", 3, "Friendly beagle who loves long walks"));
        pets.Add(new Pet("Whiskers", "Cat", 5, "Calm tabby who naps in sunny windows"));
        pets.Add(new Pet("Pebbles", "Rabbit", 1, "Curious lop-eared rabbit"));

        // Fill the ComboBox in code. The first item is the "(none)" option.
        cboPets.Items.Add("(none)");
        foreach (Pet pet in pets)
        {
            cboPets.Items.Add(pet);
        }

        cboPets.SelectedIndex = 0;
    }

    private void cboPets_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cboPets.SelectedIndex == 0)
        {
            // "(none)" is selected, so clear the display.
            lblName.Text = "";
            lblSpecies.Text = "";
            lblAge.Text = "";
            lblDescription.Text = "";
        }
        else
        {
            // Item 0 is "(none)", so pet number 0 is at index 1 in the ComboBox.
            Pet pet = pets[cboPets.SelectedIndex - 1];

            lblName.Text = pet.Name;
            lblSpecies.Text = "Species: " + pet.Species;
            lblAge.Text = "Age: " + pet.Age;
            lblDescription.Text = "About: " + pet.Description;
        }
    }
}
