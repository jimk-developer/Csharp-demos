using System;
using System.Windows.Forms;

namespace DEMO4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // ---- FOUR PARALLEL ARRAYS --------------------------------------
            // Index 0 of every array describes the Purple Coneflower,
            // index 1 describes the Blue Hosta, and so on.
            string[] plantNames = { "Purple Coneflower",
                                    "Blue Hosta",
                                    "Cherry Tomato",
                                    "Sweet Basil",
                                    "Boston Fern",
                                    "Red Maple",
                                    "Lavender Mist" };

            string[] plantTypes = { "Perennial",
                                    "Perennial",
                                    "Vegetable",
                                    "Herb",
                                    "Houseplant",
                                    "Tree",
                                    "Perennial" };

            string[] lightNeeds = { "Full Sun",
                                    "Full Shade",
                                    "Full Sun",
                                    "Full Sun",
                                    "Indirect Light",
                                    "Full Sun",
                                    "Part Shade" };

            double[] prices = { 9.99, 12.49, 4.99, 3.99, 18.00, 89.95, 7.50 };

            // ---- BUILD THE SEARCH KEY --------------------------------------
            string keyword = txtSearch.Text.Trim().ToLower();

            if (keyword == "")
            {
                lblNameOut.Text = "";
                lblTypeOut.Text = "";
                lblLightOut.Text = "";
                lblPriceOut.Text = "";
                lblCount.Text = "";
                lblMessage.Text = "Type part of a plant name or a plant type, then click Search.";
                return;
            }

            // ---- SEARCH AND COUNT ------------------------------------------
            // matchCount is an ACCUMULATOR: it starts at 0 and grows by 1
            // every time the loop finds another match.
            int matchCount = 0;
            int firstIndex = -1;

            for (int i = 0; i < plantNames.Length; i++)
            {
                string nameLower = plantNames[i].ToLower();
                string typeLower = plantTypes[i].ToLower();

                if (nameLower.Contains(keyword) || typeLower.Contains(keyword))
                {
                    matchCount = matchCount + 1;

                    // Remember only the FIRST match. Notice there is no break
                    // here - the loop keeps going so the count stays accurate.
                    if (firstIndex == -1)
                    {
                        firstIndex = i;
                    }
                }
            }

            // ---- DISPLAY THE RESULT ----------------------------------------
            if (matchCount > 0)
            {
                lblNameOut.Text = plantNames[firstIndex];
                lblTypeOut.Text = plantTypes[firstIndex];
                lblLightOut.Text = lightNeeds[firstIndex];
                lblPriceOut.Text = prices[firstIndex].ToString("C");
                lblCount.Text = matchCount + " plant(s) matched. Showing the first one.";
                lblMessage.Text = "";
            }
            else
            {
                lblNameOut.Text = "Plant Not Found";
                lblTypeOut.Text = "Plant Not Found";
                lblLightOut.Text = "Plant Not Found";
                lblPriceOut.Text = "Plant Not Found";
                lblCount.Text = "";
                lblMessage.Text = "No plant matched \"" + txtSearch.Text.Trim() + "\".";
            }
        }
    }
}
