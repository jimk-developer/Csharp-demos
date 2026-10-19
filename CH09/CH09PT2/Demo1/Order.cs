namespace Demo1
{
    // COMPOSITION: an Order OWNS one Coffee.
    // The Order creates its own Coffee in the constructor, so the Coffee
    // cannot exist without the Order (filled diamond in the UML).
    public class Order
    {
        private string _name;
        private Coffee _coffee;   // Order HAS-A Coffee

        public Order(string name, CoffeeSize size)
        {
            _name = name;
            _coffee = new Coffee(size);   // the whole creates its part
        }

        public string Name
        {
            get { return _name; }
        }

        public Coffee Coffee
        {
            get { return _coffee; }
        }

        // Order USES its Coffee to get the price.
        public double Price
        {
            get { return _coffee.Price; }
        }

        // Example: "Fred - LARGE coffee - $3.00"
        public string Display()
        {
            return $"{_name} - {_coffee.Size} coffee - {Price:C}";
        }
    }
}
