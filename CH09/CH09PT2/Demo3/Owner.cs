namespace Demo3
{
    // Owner is the "part" a Pet has. It is created on its own first,
    // then handed to a Pet (see Pet.cs).
    public class Owner
    {
        private string _name;
        private string _phone;

        public Owner(string name, string phone)
        {
            _name = name;
            _phone = phone;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Phone
        {
            get { return _phone; }
        }
    }
}
