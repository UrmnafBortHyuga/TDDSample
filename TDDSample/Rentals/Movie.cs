namespace TDDSample.Rentals
{
    public sealed class Movie
    {
        public string Name { get; private set; }
        public MovieRentalType RentalType { get; private set; }

        public Movie(string name, MovieRentalType rentalType)
        {
            Name = name;
            RentalType = rentalType;
        }

        public int CalcFee(int rented)
        {
            var daysRented = rented;
            var pay = 0;

            if (RentalType == MovieRentalType.Childrens)
            {
                pay = 150;
                if (daysRented > 3)
                {
                    pay += (daysRented - 3) * 150;
                }
            }
            else if (RentalType == MovieRentalType.Regular)
            {
                pay = 200;
                if (daysRented > 2)
                {
                    pay += (daysRented - 2) * 200;
                }
            }
            else if (RentalType == MovieRentalType.NewRelease)
            {
                pay = daysRented * 300;
            }
            return pay;
        }
    }
}