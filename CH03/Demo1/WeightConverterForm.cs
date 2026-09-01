namespace Demo1
{
    public partial class WeightConverterForm : Form
    {
        private const double KG_PER_POUND = 0.45;

        public WeightConverterForm()
        {
            InitializeComponent();
        }

        private void btnConvertToKilograms_Click(object sender, EventArgs e)
        {
            double pounds = Convert.ToDouble(txtWeightInPounds.Text);
            double kilograms = pounds * KG_PER_POUND;

            txtWeightInKilograms.Text = kilograms.ToString("F1");

            lblResult.Text = pounds.ToString("F1") + " pounds is " + kilograms.ToString("F1") + " kilograms";
        }

        private void btnConvertToPounds_Click(object sender, EventArgs e)
        {
            double kilograms = Convert.ToDouble(txtWeightInKilograms.Text);
            double pounds = kilograms / KG_PER_POUND;

            txtWeightInPounds.Text = pounds.ToString("F1");

            lblResult.Text = kilograms.ToString("F1") + " kilograms is " + pounds.ToString("F1") + " pounds";
        }
    }
}
