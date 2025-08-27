using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature temperature = new Temperature();
            temperature.SetTemperature(500);
            temperature.Location = "Salon";
            temperature.BilgileriGetir();
        }
    }
}
