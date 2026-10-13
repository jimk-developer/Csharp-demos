namespace Demo1
{
    // A State object holds one state name and its capital.
    public class State
    {
        // Fields (private - only this class can see them)
        private string _name;
        private string _capital;

        // Constructor - runs when we say "new State(...)"
        public State(string name, string capital)
        {
            _name = name;
            _capital = capital;
        }

        // Getter methods - let other code READ the private fields
        public string GetName()
        {
            return _name;
        }

        public string GetCapital()
        {
            return _capital;
        }
    }
}
