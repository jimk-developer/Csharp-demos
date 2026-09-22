using System;
using System.Windows.Forms;

namespace DEMO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            // ---- PARALLEL ARRAYS -------------------------------------------
            // Element 0 of stateCodes goes with element 0 of shippingCharges,
            // element 1 goes with element 1, and so on. Same length, always.
            string[] stateCodes = { "MO", "IL", "KS", "IA", "NE",
                                    "AR", "OK", "TN", "KY", "IN" };

            double[] shippingCharges = { 5.50, 6.25, 7.00, 8.75, 9.50,
                                         6.75, 10.25, 11.00, 12.50, 9.00 };

            // ---- GET THE SEARCH VALUE --------------------------------------
            // Trim() removes stray spaces, ToUpper() makes "mo" match "MO".
            string searchCode = txtStateCode.Text.Trim().ToUpper();

            // ---- LINEAR (SEQUENTIAL) SEARCH --------------------------------
            bool found = false;       // flag  - did we find it?
            double charge = 0.0;      // holds the answer when we do

            for (int i = 0; i < stateCodes.Length; i++)
            {
                if (stateCodes[i] == searchCode)
                {
                    found = true;
                    charge = shippingCharges[i];   // SAME index in both arrays
                    break;                         // stop early, we are done
                }
            }

            // ---- DISPLAY THE RESULT ----------------------------------------
            if (found)
            {
                lblCharge.Text = charge.ToString("C");
                lblError.Text = "";                // clear the old error message
            }
            else
            {
                lblCharge.Text = "";
                lblError.Text = "State code \"" + searchCode + "\" was not found.";
            }
        }
    }
}
