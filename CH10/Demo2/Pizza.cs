namespace Demo2;

// Relationships:
//   Pizza IS-A System.Object.
//   Pizza is the BASE CLASS of StuffedCrustPizza and DeepDishPizza.
//   The size pricing rules live here only; subclasses reuse them through base.Price.
public class Pizza
{
    protected int _size;   // diameter in inches

    public Pizza(int size)
    {
        _size = size;
    }

    public int Size
    {
        get { return _size; }
        set { _size = value; }
    }

    // virtual = subclasses may override to add their own extra cost.
    public virtual decimal Price
    {
        get
        {
            if (_size == 10)
            {
                return 8.99m;
            }
            if (_size == 14)
            {
                return 12.99m;
            }
            return 15.99m;
        }
    }

    // override = replaces Object.ToString().
    public override string ToString()
    {
        return $"{_size}\" Pizza";
    }
}
