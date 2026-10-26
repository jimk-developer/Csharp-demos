namespace Demo2;

// Relationships:
//   MainForm IS-A Form (inheritance).
//   MainForm USES Pizza, StuffedCrustPizza and DeepDishPizza (dependency): it creates one and reads it.
//   MainForm USES the Cheese and Sauce enums to turn radio buttons into values.
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        UpdateOptionGroups();
    }

    // All three crust radio buttons share this handler.
    private void Crust_CheckedChanged(object? sender, EventArgs e)
    {
        UpdateOptionGroups();
    }

    // Only the option group for the chosen crust is enabled.
    private void UpdateOptionGroups()
    {
        grpCheese.Enabled = radStuffed.Checked;
        grpSauce.Enabled = radDeepDish.Checked;
    }

    private void btnCalculate_Click(object? sender, EventArgs e)
    {
        if (!int.TryParse(txtSize.Text, out int size) || size <= 0)
        {
            MessageBox.Show("Size must be a whole number greater than 0.", "Invalid Size");
            return;
        }

        // A base-class variable can hold any of the three pizza types.
        Pizza pizza;
        if (radStuffed.Checked)
        {
            pizza = new StuffedCrustPizza(size, GetSelectedCheese());
        }
        else if (radDeepDish.Checked)
        {
            pizza = new DeepDishPizza(size, GetSelectedSauce());
        }
        else
        {
            pizza = new Pizza(size);
        }

        // Polymorphism: the real object decides which Price and ToString() run.
        lblCost.Text = $"Cost: {pizza.Price:C}";
        lblDescription.Text = pizza.ToString();
    }

    private Cheese GetSelectedCheese()
    {
        if (radCheddar.Checked)
        {
            return Cheese.CHEDDAR;
        }
        if (radPepperJack.Checked)
        {
            return Cheese.PEPPER_JACK;
        }
        return Cheese.MOZZARELLA;
    }

    private Sauce GetSelectedSauce()
    {
        if (radAlfredo.Checked)
        {
            return Sauce.ALFREDO;
        }
        if (radBbq.Checked)
        {
            return Sauce.BBQ;
        }
        return Sauce.MARINARA;
    }
}
