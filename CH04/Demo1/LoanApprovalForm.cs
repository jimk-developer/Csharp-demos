namespace Demo1
{
    public partial class LoanApprovalForm : Form
    {
        public LoanApprovalForm()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int creditscore = Convert.ToInt32(txtCreditScore.Text);
            decimal annualIncome = Convert.ToInt32(txtAnnualIncome.Text);

            if (creditscore >= 700 && annualIncome >= 30000)
            {
                lblResult.Text = "Approve";
            }
            else if (creditscore < 700 && annualIncome >= 60000)
            {
                lblResult.Text = "Approve";
            }
            else
            {
                lblResult.Text = "Deny";
            }
        }
    }
}
