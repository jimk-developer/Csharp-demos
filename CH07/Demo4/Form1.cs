// Demo 4 - Fence Estimator
// Concepts: two methods that work together - the value RETURNED by the
//           first method is passed as the ARGUMENT to the second method.

namespace Demo4
{
    public partial class Form1 : Form
    {
        private const double COST_PER_FOOT = 12.50;   // fencing price per linear foot

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLength.Text, out int length) || length <= 0)
            {
                MessageBox.Show("Please enter a whole-number length greater than 0.");
                txtLength.Focus();
                return;
            }

            if (!int.TryParse(txtWidth.Text, out int width) || width <= 0)
            {
                MessageBox.Show("Please enter a whole-number width greater than 0.");
                txtWidth.Focus();
                return;
            }

            // Step 1: get the perimeter back from the first method.
            int perimeter = CalculatePerimeter(length, width);

            // Step 2: hand that result to the second method.
            double cost = CalculateFenceCost(perimeter);

            // Nested method call alternative (same result, one line):
            // double cost = CalculateFenceCost(CalculatePerimeter(length, width));

            lblPerimeter.Text = perimeter + " ft";
            lblCost.Text = cost.ToString("C");
        }

        /// <summary>
        /// Calculates the perimeter of a rectangular yard.
        ///   perimeter = (length * 2) + (width * 2)
        /// Parameters: length and width in feet (int)
        /// Returns:    perimeter in feet (int)
        /// </summary>
        private int CalculatePerimeter(int length, int width)
        {
            int perimeter = (length * 2) + (width * 2);
            return perimeter;
        }

        /// <summary>
        /// Calculates the cost of fencing.
        /// Parameters: perimeter in feet (int)
        /// Returns:    total cost in dollars (double)
        /// </summary>
        private double CalculateFenceCost(int perimeter)
        {
            return perimeter * COST_PER_FOOT;
        }
    }
}
