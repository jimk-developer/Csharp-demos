// Demo 2 - Loan Approval Checker
// Concepts: a method that accepts TWO parameters and RETURNS a bool,
//           compound conditions with && (AND), named constants, input validation.

using System.Globalization;

namespace Demo2
{
    public partial class Form1 : Form
    {
        // Named constants make the business rules easy to read and change.
        private const int GOOD_CREDIT_SCORE = 680;
        private const double STANDARD_INCOME = 35000;
        private const double HIGH_INCOME = 70000;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Validate the credit score (range check: 300 - 850).
            if (!int.TryParse(txtCreditScore.Text, out int creditScore) ||
                creditScore < 300 || creditScore > 850)
            {
                MessageBox.Show("Please enter a whole-number credit score from 300 to 850.");
                txtCreditScore.Focus();
                return;
            }

            // NumberStyles.Currency lets the user type 72000, 72,000 or $72,000.
            if (!double.TryParse(txtIncome.Text, NumberStyles.Currency,
                    CultureInfo.CurrentCulture, out double annualIncome) || annualIncome < 0)
            {
                MessageBox.Show("Please enter a valid annual income.");
                txtIncome.Focus();
                return;
            }

            // Pass the two values as ARGUMENTS. The returned bool is stored
            // in a local variable and used to decide what to display.
            bool approved = IsLoanApproved(creditScore, annualIncome);

            if (approved)
            {
                lblResult.Text = "Approved";
            }
            else
            {
                lblResult.Text = "Denied";
            }
        }

        /// <summary>
        /// Decides whether a loan applicant is approved.
        ///   - Approved if credit score is 680+ AND income is $35,000+
        ///   - Approved if credit score is below 680 AND income is $70,000+
        ///   - Otherwise denied
        /// Parameters: creditScore (int), annualIncome (double)
        /// Returns:    true if approved, false if denied
        /// </summary>
        private bool IsLoanApproved(int creditScore, double annualIncome)
        {
            if (creditScore >= GOOD_CREDIT_SCORE && annualIncome >= STANDARD_INCOME)
            {
                return true;
            }
            else if (creditScore < GOOD_CREDIT_SCORE && annualIncome >= HIGH_INCOME)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
