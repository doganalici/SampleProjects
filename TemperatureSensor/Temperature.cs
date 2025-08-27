using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureSensor
{
    public class Temperature
    {
        private double ThermometerValue { get; set; }
        public string Location { get; set; }

        public void SetTemperature(double value)
        {
            if (value < -100 || value > 1000)
            {
                Console.WriteLine("Hatalı derece girişi. Lütfen -100 ile 1000 derece arasında değer giriniz!");
            }
            else
            {
                this.ThermometerValue = value;
            }
        }
        public double GetTemperature()
        {
            return ThermometerValue;
        }
        public void BilgileriGetir()
        {
            Console.WriteLine($"Termometre üzerindeki derece : {ThermometerValue}");
            Console.WriteLine($"Termometrenin bulunduğu lokasyon : {Location}");
        }
    }
}
