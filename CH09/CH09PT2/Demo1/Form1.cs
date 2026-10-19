namespace Demo1
{
    // Form1 USES Order objects: it creates one per click and displays it.
    public partial class Form1 : Form
    {
        private double _total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            // 1. Name is required
            if (name == "")
            {
                lblError.Text = "Name required";
                txtName.Focus();
                return;
            }

            // 2. Convert the checked radio button to a CoffeeSize value
            CoffeeSize size = CoffeeSize.SMALL;
            if (radMedium.Checked)
            {
                size = CoffeeSize.MEDIUM;
            }
            else if (radLarge.Checked)
            {
                size = CoffeeSize.LARGE;
            }

            // 3. Create the Order (the Order creates its own Coffee)
            Order order = new Order(name, size);

            // 4. Show the order
            lstOrders.Items.Add(order.Display());

            // 5. Update the running total
            _total += order.Price;
            lblTotal.Text = $"Total: {_total:C}";

            // 6. Reset for the next order
            txtName.Clear();
            lblError.Text = "";
            txtName.Focus();
        }
    }
}
