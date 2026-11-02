namespace Demo2
{
    public class Ticket
    {
        private int _row;
        private int _seat;

        // The constructor uses the properties, so the same range checks run here too.
        public Ticket(int row, int seat)
        {
            Row = row;
            Seat = seat;
        }

        public int Row
        {
            get { return _row; }
            set
            {
                if (value < 1 || value > 20)
                {
                    throw new InvalidRowException();
                }
                _row = value;
            }
        }

        public int Seat
        {
            get { return _seat; }
            set
            {
                if (value < 1 || value > 30)
                {
                    throw new InvalidSeatException();
                }
                _seat = value;
            }
        }
    }
}
