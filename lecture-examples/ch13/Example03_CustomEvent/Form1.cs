// =====================================================================
//  EXAMPLE 3: Declaring and Handling Your Own Event
//
//  Key ideas:
//   - The Inventory class (see Inventory.cs) declares a public event
//     named StockLow and raises it when stock gets low.
//   - This Form is a CLIENT of Inventory. It decides which method runs
//     when StockLow happens by SUBSCRIBING with +=.
//   - You can only do TWO things to an event from outside its class:
//         +=  add (compose) a handler
//         -=  remove a handler
//
//  Try this:
//   1. Click "Sell One" until the alert appears.
//   2. Uncheck the CheckBox (-=) and sell again. No alert appears.
//   3. Check it again (+=) and the alerts come back.
// =====================================================================

namespace Example03_CustomEvent;

public partial class Form1 : Form
{
    private Inventory store = new Inventory(6);

    public Form1()
    {
        InitializeComponent();

        // SUBSCRIBE: when store raises StockLow, run Store_StockLow()
        store.StockLow += Store_StockLow;

        // This would NOT compile. You cannot assign to an event:
        // store.StockLow = Store_StockLow;

        ShowQuantity();
    }

    // The EVENT HANDLER for the Inventory's StockLow event.
    // It matches the EventHandler delegate: (object sender, EventArgs e)
    private void Store_StockLow(object sender, EventArgs e)
    {
        Inventory lowStore = (Inventory)sender;
        alertLabel.Text = "LOW STOCK! Only " + lowStore.Quantity + " left.";
    }

    private void sellButton_Click(object sender, EventArgs e)
    {
        alertLabel.Text = "";
        store.SellOne();   // may raise the StockLow event
        ShowQuantity();
    }

    private void restockButton_Click(object sender, EventArgs e)
    {
        store.Restock(5);
        alertLabel.Text = "";
        ShowQuantity();
    }

    private void alertsCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (alertsCheckBox.Checked)
        {
            store.StockLow += Store_StockLow;   // subscribe
            alertsCheckBox.Text = "Low-stock alerts ON  ( += )";
        }
        else
        {
            store.StockLow -= Store_StockLow;   // unsubscribe
            alertsCheckBox.Text = "Low-stock alerts OFF  ( -= )";
        }
    }

    private void ShowQuantity()
    {
        quantityLabel.Text = "Items in stock: " + store.Quantity;
    }
}
