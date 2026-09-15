// ---------------------------------------------------------------------------
// Demo 4 - Campus Kiosk Donations (WinForms)
// Chapter 5 demo: the same problem as Demo 3, but event-driven
//
// The UI is one text box and one button per kiosk, plus labels for the
// results - the same controls used in the Chapter 5 labs.
//
// THE POINT OF THIS DEMO:
//   Demo 3 used a loop to ask "which kiosk?" over and over. Here the three
//   buttons ARE that question, and one click is one iteration.
//
//   The six accumulators are declared as FIELDS of the form, not inside a
//   button handler. A variable declared inside a handler is created and
//   destroyed on every click, so every total would come out equal to the
//   last donation entered. This is the most common mistake on this lab.
//
// ABOUT THE REPETITION:
//   The three handlers look almost the same, and that is expected at this
//   point in the course - the only tools for removing that duplication are
//   methods and classes, which come later. Point it out when you demo this:
//   "notice I typed that three times" is exactly the itch the next chapters
//   scratch. Each handler differs only in which two accumulators it adds to.
//
// Part of the Demo4 project. Open Demo4.slnx in Visual Studio and press F5.
// ---------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demo4;

public partial class KioskForm : Form
{
    private const double MinDonation = 0.01;
    private const double MaxDonation = 500.00;

    // ---- Class-scope accumulators: they survive from click to click --------
    private double atriumTotal = 0;
    private double bookstoreTotal = 0;
    private double commonsTotal = 0;
    private int atriumCount = 0;
    private int bookstoreCount = 0;
    private int commonsCount = 0;

    public KioskForm()
    {
        InitializeComponent();
    }

    private void btnAtrium_Click(object sender, EventArgs e)
    {
        double amount;

        // Short-circuit evaluation: if TryParse fails, the two range tests
        // are never evaluated - which matters, because "amount" would be 0
        // and meaningless.
        if (!double.TryParse(txtAmount.Text, out amount) ||
            amount < MinDonation || amount > MaxDonation)
        {
            lblError.Text = "Invalid donation";
            txtAmount.SelectAll();
            txtAmount.Focus();
            return;
        }

        lblError.Text = "";

        // The only two lines that differ between the three handlers.
        atriumTotal += amount;
        atriumCount++;

        lblAtrium.Text = $"Atrium Donations: {atriumTotal:C} ({atriumCount})";
        lblBookstore.Text = $"Bookstore Donations: {bookstoreTotal:C} ({bookstoreCount})";
        lblCommons.Text = $"Commons Donations: {commonsTotal:C} ({commonsCount})";
        lblGrand.Text = $"Grand Total: {atriumTotal + bookstoreTotal + commonsTotal:C}";

        // Largest of three, written with the conditional operator. Ties go to
        // the kiosk listed first - decide the rule out loud, do not let it be
        // an accident of which comparison happens to run first.
        string leader = (atriumTotal >= bookstoreTotal && atriumTotal >= commonsTotal) ? "Atrium"
                      : (bookstoreTotal >= commonsTotal) ? "Bookstore"
                      : "Commons";

        lblLeader.Text = leader + " has the most donations";

        txtAmount.Clear();
        txtAmount.Focus();
    }

    private void btnBookstore_Click(object sender, EventArgs e)
    {
        double amount;

        if (!double.TryParse(txtAmount.Text, out amount) ||
            amount < MinDonation || amount > MaxDonation)
        {
            lblError.Text = "Invalid donation";
            txtAmount.SelectAll();
            txtAmount.Focus();
            return;
        }

        lblError.Text = "";

        bookstoreTotal += amount;
        bookstoreCount++;

        lblAtrium.Text = $"Atrium Donations: {atriumTotal:C} ({atriumCount})";
        lblBookstore.Text = $"Bookstore Donations: {bookstoreTotal:C} ({bookstoreCount})";
        lblCommons.Text = $"Commons Donations: {commonsTotal:C} ({commonsCount})";
        lblGrand.Text = $"Grand Total: {atriumTotal + bookstoreTotal + commonsTotal:C}";

        string leader = (atriumTotal >= bookstoreTotal && atriumTotal >= commonsTotal) ? "Atrium"
                      : (bookstoreTotal >= commonsTotal) ? "Bookstore"
                      : "Commons";

        lblLeader.Text = leader + " has the most donations";

        txtAmount.Clear();
        txtAmount.Focus();
    }

    private void btnCommons_Click(object sender, EventArgs e)
    {
        double amount;

        if (!double.TryParse(txtAmount.Text, out amount) ||
            amount < MinDonation || amount > MaxDonation)
        {
            lblError.Text = "Invalid donation";
            txtAmount.SelectAll();
            txtAmount.Focus();
            return;
        }

        lblError.Text = "";

        commonsTotal += amount;
        commonsCount++;

        lblAtrium.Text = $"Atrium Donations: {atriumTotal:C} ({atriumCount})";
        lblBookstore.Text = $"Bookstore Donations: {bookstoreTotal:C} ({bookstoreCount})";
        lblCommons.Text = $"Commons Donations: {commonsTotal:C} ({commonsCount})";
        lblGrand.Text = $"Grand Total: {atriumTotal + bookstoreTotal + commonsTotal:C}";

        string leader = (atriumTotal >= bookstoreTotal && atriumTotal >= commonsTotal) ? "Atrium"
                      : (bookstoreTotal >= commonsTotal) ? "Bookstore"
                      : "Commons";

        lblLeader.Text = leader + " has the most donations";

        txtAmount.Clear();
        txtAmount.Focus();
    }
}
