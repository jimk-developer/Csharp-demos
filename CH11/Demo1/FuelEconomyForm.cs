using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demo1
{
    public partial class FuelEconomyForm : Form
    {
        public FuelEconomyForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                float miles;
                float gallons;

                // float.Parse throws a FormatException if the text is not a number.
                // We catch it and throw our own exception so the user sees the right message.
                try
                {
                    miles = float.Parse(txtMiles.Text);
                }
                catch (FormatException)
                {
                    throw new InvalidMilesException();
                }

                try
                {
                    gallons = float.Parse(txtGallons.Text);
                }
                catch (FormatException)
                {
                    throw new InvalidGallonsException();
                }

                // CalcMpg throws InvalidMilesException or InvalidGallonsException
                // when a value is out of range.
                Trip trip = MpgCalculator.CalcMpg(miles, gallons);

                lblResult.ForeColor = Color.Black;
                lblResult.Text = "MPG: " + trip.Mpg.ToString("F1") + "\nRating: " + trip.Rating;
            }
            catch (InvalidMilesException ex)
            {
                ShowError(ex.Message);
            }
            catch (InvalidGallonsException ex)
            {
                ShowError(ex.Message);
            }
        }

        private void ShowError(string message)
        {
            lblResult.ForeColor = Color.Red;
            lblResult.Text = message;
        }
    }
}
