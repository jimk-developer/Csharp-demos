namespace Demo2;

// Relationships:
//   DeepDishPizza IS-A Pizza (inheritance).
//   DeepDishPizza HAS-A Sauce (aggregation: it holds one enum value).
public class DeepDishPizza : Pizza
{
    protected Sauce _sauce;

    public DeepDishPizza(int size, Sauce sauce)
        : base(size)
    {
        _sauce = sauce;
    }

    public Sauce Sauce
    {
        get { return _sauce; }
        set { _sauce = value; }
    }

    // override: size price from Pizza + $3.50 for deep dish.
    public override decimal Price
    {
        get { return base.Price + 3.50m; }
    }

    public override string ToString()
    {
        return $"{_size}\" Deep Dish Pizza ({_sauce})";
    }
}
