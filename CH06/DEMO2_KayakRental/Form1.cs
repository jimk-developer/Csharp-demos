using System;
using System.Windows.Forms;

namespace DEMO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // ---- PARALLEL ARRAYS -------------------------------------------
            // maxHours[i] is the LAST hour that still gets hourlyRate[i].
            //   1 - 2 hours  ->  $18.00 / hour
            //   3 - 5 hours  ->  $15.00 / hour
            //   6 - 8 hours  ->  $12.00 / hour
            //   9 or more    ->  $ 9.00 / hour
            // The 9999 is a "catch-all" so the last tier always matches.
            int[] maxHours = { 2, 5, 8, 9999 };
            double[] hourlyRate = { 18.00, 15.00, 12.00, 9.00 };

            // ---- GET AND CHECK THE INPUT -----------------------------------
            int hours = 0;
            bool isNumber = int.TryParse(txtHours.Text, out hours);

            if (isNumber == false || hours < 1)
            {
                lblRate.Text = "";
                lblTotal.Text = "";
                lblError.Text = "Please enter a whole number of hours (1 or more).";
                return;
            }

            // ---- RANGE MATCH -----------------------------------------------
            // Walk the tiers from smallest to largest. The FIRST tier whose
            // maxHours is big enough is the one that applies.
            double rate = 0.0;

            for (int i = 0; i < maxHours.Length; i++)
            {
                if (hours <= maxHours[i])
                {
                    rate = hourlyRate[i];
                    break;
                }
            }

            // ---- DISPLAY THE RESULT ----------------------------------------
            double total = rate * hours;

            lblRate.Text = rate.ToString("C");
            lblTotal.Text = total.ToString("C");
            lblError.Text = "";
        }
    }
}
