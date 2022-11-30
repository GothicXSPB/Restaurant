using System.Text.Json;

namespace Restaurant
{
    public class Storage
    {
        public List<Tables> Tables { get; set; }
        public List<Reservations> Reservations { get; set; }
        public string Path { get; set; }

        public Storage()
        {
            Tables = new List<Tables>();
            Reservations = new List<Reservations>();
            Path = "../Restaurant.txt";
        }

        public void SaveAll()
        {
            using (StreamWriter sw = new StreamWriter(Path))
            {
                string jsn = JsonSerializer.Serialize(Tables);
                sw.WriteLine(jsn);
                jsn = JsonSerializer.Serialize(Reservations);
                sw.WriteLine(jsn);
            }
        }

        public void LoadAll()
        {
            if (File.Exists(Path)) ;
            using (StreamReader sr = new StreamReader(Path))
            {
                
                string jsn = sr.ReadLine()!;
                Tables = JsonSerializer.Deserialize<List<Tables>>(jsn)!;
                jsn = sr.ReadLine()!;
                Reservations = JsonSerializer.Deserialize<List<Reservations>>(jsn)!;
            }
        }
    }
}
