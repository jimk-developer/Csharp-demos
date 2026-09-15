// ---------------------------------------------------------------------------
// Demo 2 - Rainfall Log (WinForms)
// Chapter 5 demo: the same problem as Demo 1, but event-driven
//
// The whole UI is one label, one text box, one button, and a few labels for
// the results - the same controls used in the Chapter 5 labs.
//
// THE POINT OF THIS DEMO:
//   In Demo 1 a while loop asked for readings over and over. Here there is no
//   loop at all for gathering input - the user clicking "Enter" IS the loop,
//   and one click is one iteration.
//
//   That changes where the accumulators have to live. They are declared as
//   FIELDS of the form (class scope), not as local variables inside the
//   button's event handler. A local variable in the handler is created and
//   destroyed on every click, so every total would come out equal to the last
//   reading entered. This is the single most common mistake on this lab.
//
// Part of the Demo2 project. Open Demo2.slnx in Visual Studio and press F5.
// ---------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demo2;

public partial class RainfallForm : Form
{
    private const double MinReading = 0.0;
    private const double MaxReading = 20.0;

    // ---- Class-scope accumulators: they survive from click to click --------
    private int readingCount = 0;      // counter accumulator
    private double totalRainfall = 0;  // sum accumulator
    private double wettestReading = 0; // running maximum
    private int dryDayCount = 0;       // conditional counter

    public RainfallForm()
    {
        InitializeComponent();
    }

    // One click = one iteration of what used to be the while loop.
    private void btnEnter_Click(object sender, EventArgs e)
    {
        double reading;

        // Same two tests as Demo 1, in the same order. There is no sentinel
        // in the GUI version - the results are simply always on screen.
        if (!double.TryParse(txtReading.Text, out reading) ||
            reading < MinReading || reading > MaxReading)
        {
            lblError.Text = "Invalid reading";
            txtReading.SelectAll();
            txtReading.Focus();
            return;
        }

        lblError.Text = "";

        // Valid reading: update every accumulator.
        readingCount++;
        totalRainfall += reading;

        if (readingCount == 1 || reading > wettestReading)
        {
            wettestReading = reading;
        }

        if (reading == MinReading)
        {
            dryDayCount++;
        }

        // Redisplay everything. With no methods yet, this block lives right
        // here in the handler.
        // Safe to divide: readingCount was just incremented above, so it
        // can never be zero here.
        double average = totalRainfall / readingCount;

        lblCount.Text = $"Number of readings: {readingCount}";
        lblTotal.Text = $"Total rainfall: {totalRainfall:F2}";
        lblAverage.Text = $"Average reading: {average:F2}";
        lblWettest.Text = $"Wettest reading: {wettestReading:F2}";
        lblDry.Text = $"Dry days: {dryDayCount}";

        // Get the text box ready for the next entry.
        txtReading.Clear();
        txtReading.Focus();
    }
}
