namespace Demo2
{
    public partial class AirQualityForm : Form
    {
        public AirQualityForm()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int aqi = Convert.ToInt32(txtAqi.Text);

            if (aqi >= 310)
            {
                txtCategory.Text = "Hazardous";
            }
            else if (aqi >= 201)
            {
                txtCategory.Text = "Very Unhealthy";

            }
            else if (aqi >= 151)
            {
                txtCategory.Text = "Unhealthy";

            }
            else if (aqi >= 101)
            {
                txtCategory.Text = "Unhealthy for Sensitive Groups";

            }
            else if (aqi >= 51)
            {
                txtCategory.Text = "Moderate";

            }
            else
            {
                txtCategory.Text = "Good";

            }
        }
    }
}
