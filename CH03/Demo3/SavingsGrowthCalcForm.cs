namespace Demo3
{
    public partial class SavingsGrowthCalcForm : Form
    {
        private const decimal INTEREST_RATE = 1.03m;
        public SavingsGrowthCalcForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name1 = txtName1.Text;
            decimal balance1 = Convert.ToDecimal(txtBalance1.Text);
            decimal balance1Year1 = balance1 * INTEREST_RATE;
            decimal balance1Year2 = balance1Year1 * INTEREST_RATE;
            decimal balance1Year3 = balance1Year2 * INTEREST_RATE;

            string name2 = txtName2.Text;
            decimal balance2 = Convert.ToDecimal(txtBalance2.Text);
            decimal balance2Year1 = balance2 * INTEREST_RATE;
            decimal balance2Year2 = balance2Year1 * INTEREST_RATE;
            decimal balance2Year3 = balance2Year2 * INTEREST_RATE;

            string name3 = txtName3.Text;
            decimal balance3 = Convert.ToDecimal(txtBalance3.Text);
            decimal balance3Year1 = balance3 * INTEREST_RATE;
            decimal balance3Year2 = balance3Year1 * INTEREST_RATE;
            decimal balance3Year3 = balance3Year2 * INTEREST_RATE;

            lblResult.Text =
                "Year".PadRight(12) + name1.PadRight(12) + name2.PadRight(12) + name3.PadRight(12) + "\r\n" +
                "1".PadRight(12) + balance1Year1.ToString("C").PadRight(12) + balance2Year1.ToString("C").PadRight(12) + balance3Year1.ToString("C").PadRight(12) + "\r\n" +
                "2".PadRight(12) + balance1Year2.ToString("C").PadRight(12) + balance2Year2.ToString("C").PadRight(12) + balance3Year2.ToString("C").PadRight(12) + "\r\n" +
                "3".PadRight(12) + balance1Year3.ToString("C").PadRight(12) + balance2Year3.ToString("C").PadRight(12) + balance3Year3.ToString("C").PadRight(12);

        }
    }
}
