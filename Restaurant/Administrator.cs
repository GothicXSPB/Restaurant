
namespace Restaurant
{
    public class Administrator
    {
        public Storage _storage { get; set; }      
        
        public Administrator()
        {
            _storage = new Storage();
            _storage.LoadAll();
        }

        public void BuyTable(Tables table)
        {
            _storage.Tables.Add(table);
            _storage.SaveAll();
        }

        public void WriteOffTheTable(int number)
        {
            _storage.Tables.RemoveAt(number);
            _storage.SaveAll();
        }

        public void ReserveATable(Reservations reservations)
        {

            _storage.Reservations.Add(reservations);
            _storage.SaveAll();
        }

        public void CancelYourReserve(int id)
        {
            _storage.Reservations.RemoveAt(id);
            _storage.SaveAll();
        }

        public void ShowReservations(List<Reservations> Reservtions)
        {
            foreach(Reservations i in Reservtions)
            {
                Console.WriteLine($"Номер стола:{i.TableNumber} Id:{i.Id} Имя:{i.CustomerName} Телефон:{i.CustomerTelephon} Дата:{i.Date} Время:{i.Time} Кол-во гостей:{i.NumberOfGuests}");
            }
        }
        
        public void ShowReservationsAtDay(List<Reservations> Reservtions,string date)
        {
            foreach(Reservations i in Reservtions)
            {
                if(i.Date==date)
                Console.WriteLine($"Номер стола:{i.TableNumber} Id:{i.Id} Имя:{i.CustomerName} Телефон:{i.CustomerTelephon} Дата:{i.Date} Время:{i.Time} Кол-во гостей:{i.NumberOfGuests}");
            }
        }

        public void ShowReservationsForThatTable(List<Reservations> Reservtions, int tableNumber)
        {
            foreach (Reservations i in Reservtions)
            {
                if (i.TableNumber == tableNumber)
                    Console.WriteLine($"Номер стола:{i.TableNumber} Id:{i.Id} Имя:{i.CustomerName} Телефон:{i.CustomerTelephon} Дата:{i.Date} Время:{i.Time} Кол-во гостей:{i.NumberOfGuests}");
            }
        }

        public void FindingSuitableTables(List<Reservations> Reservtions, List<Reservations> Tables, int numberOfGuests)
        {
            
            foreach (Reservations i in Reservtions)
            {
                if (i.TableNumber == null)
                {

                }
                    
            }
        }
    }
}
