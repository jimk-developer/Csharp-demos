// =====================================================================
//  Inventory.cs
//  This class declares and RAISES its own event named StockLow.
//  It does not know (or care) which methods will respond.
//  Other classes, called CLIENTS, decide that by subscribing.
// =====================================================================

namespace Example03_CustomEvent;

internal class Inventory
{
    // The event is PUBLIC so client classes can subscribe to it.
    // EventHandler is a delegate built into .NET for events that
    // send no extra information. Its methods look like this:
    //     void MethodName(object sender, EventArgs e)
    public event EventHandler StockLow;

    // You could instead declare your own delegate type first:
    //     public delegate void StockLowEventHandler(object sender, EventArgs e);
    //     public event StockLowEventHandler StockLow;

    public const int LowLimit = 3;
    private int quantity;

    public Inventory(int startingQuantity)
    {
        quantity = startingQuantity;
    }

    public int Quantity
    {
        get { return quantity; }
    }

    public void SellOne()
    {
        if (quantity > 0)
        {
            quantity--;
        }

        if (quantity <= LowLimit)
        {
            OnStockLow();
        }
    }

    public void Restock(int amount)
    {
        quantity += amount;
    }

    // INVOKING the event. Every method that clients have
    // subscribed to StockLow runs, one after another.
    private void OnStockLow()
    {
        // If no client has subscribed, StockLow is null.
        if (StockLow != null)
        {
            // this             = the sender (this Inventory object)
            // EventArgs.Empty  = there is no extra information to send
            StockLow(this, EventArgs.Empty);
        }
    }
}
