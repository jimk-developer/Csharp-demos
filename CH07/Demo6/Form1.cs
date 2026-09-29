// Demo 6 - Pizza Price Estimator
// Concepts: breaking a problem into several small methods.
//   - "Get" methods take no parameters and RETURN a value read from the form
//   - "Calculate" methods take parameters and RETURN a result
//   - CalculateTotalCost() CALLS the other calculate methods

namespace Demo6
{
    public partial class Form1 : Form
    {
        private const double PERSONAL_COST = 6.00;
        private const double SMALL_COST = 8.00;
        private const double MEDIUM_COST = 10.00;
        private const double LARGE_COST = 13.00;
        private const double COST_PER_TOPPING = 1.50;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            // Gather input using the Get methods.
            string size = GetSize();
            int numToppings = GetToppings();

            // Use the returned values as arguments to the Calculate methods.
            double sizeCost = CalculateSizeCost(size);
            double toppingCost = CalculateToppingCost(numToppings);
            double totalCost = CalculateTotalCost(size, numToppings);

            lblSizeCost.Text = sizeCost.ToString("C");
            lblToppingCost.Text = toppingCost.ToString("C");
            lblTotalCost.Text = totalCost.ToString("C");
        }

        /// <summary>
        /// Reads the size code from the form.
        ///   "s" = small, "m" = medium, "l" = large, anything else = personal
        /// Parameters: none      Returns: the size name (string)
        /// </summary>
        private string GetSize()
        {
            string code = txtSize.Text.Trim().ToLower();

            if (code == "s")
            {
                return "small";
            }
            else if (code == "m")
            {
                return "medium";
            }
            else if (code == "l")
            {
                return "large";
            }
            else
            {
                return "personal";
            }
        }

        /// <summary>
        /// Reads the number of toppings from the form.
        /// Invalid or negative input counts as 0 toppings.
        /// Parameters: none      Returns: number of toppings (int)
        /// </summary>
        private int GetToppings()
        {
            if (int.TryParse(txtToppings.Text, out int toppings) && toppings >= 0)
            {
                return toppings;
            }

            MessageBox.Show("Invalid number of toppings - using 0.");
            txtToppings.Text = "0";
            return 0;
        }

        /// <summary>
        /// Looks up the base price for a pizza size.
        /// Parameters: size (string)   Returns: cost (double)
        /// </summary>
        private double CalculateSizeCost(string size)
        {
            switch (size)
            {
                case "small":
                    return SMALL_COST;
                case "medium":
                    return MEDIUM_COST;
                case "large":
                    return LARGE_COST;
                default:
                    return PERSONAL_COST;
            }
        }

        /// <summary>
        /// Calculates the extra charge for toppings.
        /// Parameters: numToppings (int)   Returns: cost (double)
        /// </summary>
        private double CalculateToppingCost(int numToppings)
        {
            return numToppings * COST_PER_TOPPING;
        }

        /// <summary>
        /// Calculates the full price of the pizza by CALLING the two
        /// methods above - no need to repeat their logic here.
        /// Parameters: size (string), numToppings (int)   Returns: cost (double)
        /// </summary>
        private double CalculateTotalCost(string size, int numToppings)
        {
            return CalculateSizeCost(size) + CalculateToppingCost(numToppings);
        }
    }
}
