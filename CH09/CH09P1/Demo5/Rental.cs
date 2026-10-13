namespace Demo5
{
    // A Rental object estimates the cost of renting a car.
    // It uses PROPERTIES instead of Get/Set methods.
    public class Rental
    {
        // A public constant - the same for every rental
        public const decimal INSURANCE_FEE = 25;

        private string _customer;
        private int _days;
        private decimal _dailyRate;
        private decimal _totalCost;

        public Rental(string customer, int days, decimal dailyRate)
        {
            _customer = customer;
            _days = days;
            _dailyRate = dailyRate;
            CalculateTotal();
        }

        // Private helper - only this class can call it
        private void CalculateTotal()
        {
            _totalCost = _days * _dailyRate + INSURANCE_FEE;
        }

        // ---------- Properties ----------

        public string Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        public int Days
        {
            get { return _days; }
            set
            {
                _days = value;
                CalculateTotal();   // days changed, so the total changes
            }
        }

        public decimal DailyRate
        {
            get { return _dailyRate; }
            set
            {
                _dailyRate = value;
                CalculateTotal();   // rate changed, so the total changes
            }
        }

        // Read-only: there is no "set", so the form can't change it
        public decimal TotalCost
        {
            get { return _totalCost; }
        }
    }
}
