using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Reservations
    {        
        public int TableNumber { get; private set; }

        public string CustomerName { get; set; }

        public string CustomerTelephon { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public int NumberOfGuests { get; set; }

        public int Id { get; set; }

        public Reservations(int id, string customerName, string customerTelephon, string date, string time, int numberofguests)
        {
            Id= id;
            CustomerName= customerName;
            CustomerTelephon= customerTelephon;
            Date= date;
            Time= time;
            NumberOfGuests= numberofguests;
        }
    }
}
