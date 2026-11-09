namespace Demo2;

public partial class MainForm : Form
{
    private Category[] categories = new Category[3];

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        // Create the menu items for each category.
        MenuItem[] breakfastItems =
        {
            new MenuItem("Pancakes", 6.50m, 520),
            new MenuItem("Omelet", 7.25m, 410)
        };

        MenuItem[] lunchItems =
        {
            new MenuItem("Turkey Club", 8.99m, 640),
            new MenuItem("Garden Salad", 6.75m, 320)
        };

        MenuItem[] dessertItems =
        {
            new MenuItem("Brownie", 3.50m, 380),
            new MenuItem("Apple Pie", 4.25m, 410)
        };

        // Create the categories.
        categories[0] = new Category("Breakfast", breakfastItems);
        categories[1] = new Category("Lunch", lunchItems);
        categories[2] = new Category("Dessert", dessertItems);

        // Fill the ListBox in code.
        foreach (Category category in categories)
        {
            lstCategories.Items.Add(category);
        }
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        if (lstCategories.SelectedItems.Count == 0)
        {
            MessageBox.Show("Please select at least one category.", "Menu Finder");
            return;
        }

        // Collect every item from every selected category.
        List<MenuItem> results = new List<MenuItem>();

        foreach (Category category in lstCategories.SelectedItems)
        {
            foreach (MenuItem item in category.Items)
            {
                results.Add(item);
            }
        }

        // Show the results in a new window.
        ResultsForm resultsForm = new ResultsForm(results);
        resultsForm.ShowDialog();
    }
}
