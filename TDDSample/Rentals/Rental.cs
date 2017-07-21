using NUnit.Framework;

namespace TDDSample.Rentals
{
    public sealed class Rental
    {
        public Movie Movie { get; private set; }
        public int DaysRented { get; private set; }

        public Rental(Movie movie, int daysRented)
        {
            Movie = movie;
            DaysRented = daysRented;
        }
        public int CalcFee()
        {
            return Movie.CalcFee(DaysRented);
        }
    }
}