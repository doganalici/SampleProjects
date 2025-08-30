using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine($"--> {Brand} marka araç çalıştırıldı");
            Console.WriteLine("----------------------------------------");

        }
        public void Stop()
        {
            Console.WriteLine($"--> {Brand} marka araç durduruldu");
            Console.WriteLine("----------------------------------------");

        }
    }
}
