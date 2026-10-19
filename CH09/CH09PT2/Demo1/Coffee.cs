namespace Demo1
{
    // Coffee USES the CoffeeSize enum to store its size.
    // Coffee is the "part" that an Order owns (see Order.cs).
    public class Coffee
    {
        public const double BASE_PRICE = 2.00;
        public const double SIZE_PRICE = 0.50;

        private CoffeeSize _size;

        public Coffee(CoffeeSize size)
        {
            _size = size;
        }

        public CoffeeSize Size
        {
            get { return _size; }
        }

        // SMALL = 2.00, MEDIUM = 2.50, LARGE = 3.00
        public double Price
        {
            get { return BASE_PRICE + (int)_size * SIZE_PRICE; }
        }
    }
}
