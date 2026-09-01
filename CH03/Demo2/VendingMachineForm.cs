namespace Demo2
{
    public partial class VendingMachineForm : Form
    {
        private const int SNACKS_PER_CASE = 24;
        public VendingMachineForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int machine1 = Convert.ToInt32(txtMachine1.Text);
            int machine2 = Convert.ToInt32(txtMachine2.Text);
            int machine3 = Convert.ToInt32(txtMachine3.Text);
            int machine4 = Convert.ToInt32(txtMachine4.Text);

            int totalSnacks = machine1 + machine2 + machine3 + machine4;
            int cases = totalSnacks / SNACKS_PER_CASE;
            int leftoverSnacks = totalSnacks % SNACKS_PER_CASE;

            lblResult.Text = totalSnacks + " snacks total, or " + cases + " cases and " + leftoverSnacks + " snacks";



        }
    }
}
