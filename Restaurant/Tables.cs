namespace Restaurant
{
    public class Tables
    {
        public int Number { get; set; }

        public int Seats { get; set; }

        public Tables(int number, int seats)
        {
            Number = number;
            Seats = seats;
        }
    }
}
