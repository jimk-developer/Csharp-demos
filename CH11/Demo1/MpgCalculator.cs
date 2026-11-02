namespace Demo1
{
    public static class MpgCalculator
    {
        // Returns a Trip, or throws an exception if miles or gallons is out of range.
        public static Trip CalcMpg(float miles, float gallons)
        {
            if (miles < 1 || miles > 1000)
            {
                throw new InvalidMilesException();
            }

            if (gallons < 1 || gallons > 50)
            {
                throw new InvalidGallonsException();
            }

            float mpg = miles / gallons;

            MpgRating rating;
            if (mpg < 20)
            {
                rating = MpgRating.POOR;
            }
            else if (mpg < 30)
            {
                rating = MpgRating.AVERAGE;
            }
            else
            {
                rating = MpgRating.GOOD;
            }

            return new Trip(miles, gallons, mpg, rating);
        }
    }
}
