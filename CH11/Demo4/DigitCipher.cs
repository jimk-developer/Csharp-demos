using System;

namespace Demo4
{
    public class DigitCipher
    {
        private int _key;

        public DigitCipher()
        {
            _key = 0;
        }

        public int Key
        {
            get { return _key; }
            set
            {
                if (value < 0 || value > 9)
                {
                    throw new ArgumentOutOfRangeException("Key", "Key must be in the range [0, 9]");
                }
                _key = value;
            }
        }

        // Adds the key to each digit, wrapping past 9 back to 0.
        public string Encode(string text)
        {
            string result = "";

            foreach (char c in text)
            {
                if (c < '0' || c > '9')
                {
                    throw new InvalidCharacterException();
                }

                int digit = c - '0';
                int shifted = (digit + _key) % 10;
                result += shifted;
            }

            return result;
        }

        // Subtracts the key from each digit, wrapping below 0 back to 9.
        public string Decode(string text)
        {
            string result = "";

            foreach (char c in text)
            {
                if (c < '0' || c > '9')
                {
                    throw new InvalidCharacterException();
                }

                int digit = c - '0';
                int shifted = (digit - _key + 10) % 10;
                result += shifted;
            }

            return result;
        }
    }
}
