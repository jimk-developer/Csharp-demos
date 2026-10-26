namespace Demo2;

// Relationships:
//   StuffedCrustPizza IS-A Pizza (inheritance).
//   StuffedCrustPizza HAS-A Cheese (aggregation: it holds one enum value).
public class StuffedCrustPizza : Pizza
{
    protected Cheese _cheese;

    // : base(size) lets Pizza store the size.
    public StuffedCrustPizza(int size, Cheese cheese)
        : base(size)
    {
        _cheese = cheese;
    }

    public Cheese Cheese
    {
        get { return _cheese; }
        set { _cheese = value; }
    }

    // override: size price from Pizza + $2.00 for the stuffed crust.
    public override decimal Price
    {
        get { return base.Price + 2.00m; }
    }

    public override string ToString()
    {
        return $"{_size}\" Stuffed Crust Pizza ({_cheese})";
    }
}
