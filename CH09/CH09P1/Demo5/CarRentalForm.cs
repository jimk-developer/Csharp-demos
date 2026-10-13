namespace Demo5
{
    public partial class CarRentalForm : Form
    {
        // No Rental object exists until the first click
        Rental rental = null;

        public CarRentalForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string customer = txtCustomer.Text.Trim();
            int days = int.Parse(txtDays.Text);
            decimal dailyRate = decimal.Parse(txtDailyRate.Text);

            if (rental == null)
            {
                // 1. First click: create the object
                rental = new Rental(customer, days, dailyRate);
            }
            else
            {
                // 2. Later clicks: update the properties (the setters recalculate the total)
                rental.Customer = customer;
                rental.Days = days;
                rental.DailyRate = dailyRate;
            }

            // 3. Display the property values
            lblOutput.Text =
                "Customer: " + rental.Customer + "\n" +
                "Days: " + rental.Days + "\n" +
                "Daily Rate: " + rental.DailyRate.ToString("C") + "\n" +
                "Insurance Fee: " + Rental.INSURANCE_FEE.ToString("C") + "\n" +
                "Total Cost: " + rental.TotalCost.ToString("C");
        }
    }
}
