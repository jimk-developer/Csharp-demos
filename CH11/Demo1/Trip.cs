namespace Demo1
{
    public class Trip
    {
        private float _miles;
        private float _gallons;
        private float _mpg;
        private MpgRating _rating;

        public Trip(float miles, float gallons, float mpg, MpgRating rating)
        {
            _miles = miles;
            _gallons = gallons;
            _mpg = mpg;
            _rating = rating;
        }

        public float Miles
        {
            get { return _miles; }
        }

        public float Gallons
        {
            get { return _gallons; }
        }

        public float Mpg
        {
            get { return _mpg; }
        }

        public MpgRating Rating
        {
            get { return _rating; }
        }
    }
}
