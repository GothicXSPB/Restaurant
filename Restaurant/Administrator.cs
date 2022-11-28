
namespace Restaurant
{
    public class Administrator
    {
        List<Tables> tables = new List<Tables>();

        List<Reservations> reservtions = new List<Reservations>();

        public void BuyTable(int number, int seats)
        {
            tables.Add(new Tables(number, seats));
        }

        public void WriteOffTheTable(int number)
        {
            foreach (Tables i in tables)
            {
                if (i.Number == number)
                {
                    tables.Remove(i);
                }
            }
        }

        public void ReserveATable(int id, string customerName, string customerTelephon, string date, string time, int numberofguests)
        {
            reservtions.Add(new Reservations(id, customerName, customerTelephon, date, time, numberofguests));  
        }

        public void CancelYourReserve(int id)
        {
            foreach (Reservations i in reservtions)
            {
                if (i.Id == id)
                {
                    reservtions.Remove(i);
                }
            }
        }
    }
}
