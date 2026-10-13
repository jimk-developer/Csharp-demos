namespace Demo3
{
    // A MealCard object is one student's cafeteria card.
    // AddFunds() and BuyMeal() change the object's balance.
    public class MealCard
    {
        private string _cardNumber;
        private string _pin;
        private string _studentName;
        private decimal _balance;

        public MealCard(string cardNumber, string pin, string studentName, decimal balance)
        {
            _cardNumber = cardNumber;
            _pin = pin;
            _studentName = studentName;
            _balance = balance;
        }

        public string GetCardNumber()
        {
            return _cardNumber;
        }

        public string GetPin()
        {
            return _pin;
        }

        public string GetStudentName()
        {
            return _studentName;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        // Adds money to the card
        public void AddFunds(decimal amount)
        {
            _balance += amount;
        }

        // Pays for a meal. Returns true if it worked,
        // false if there is not enough money (balance does not change).
        public bool BuyMeal(decimal amount)
        {
            if (amount > _balance)
            {
                return false;
            }

            _balance -= amount;
            return true;
        }
    }
}
