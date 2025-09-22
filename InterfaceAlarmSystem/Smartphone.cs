using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAlarmSystem
{
    public class Smartphone : IAlarm
    {
        public string AlarmTime { get; set; }
        public void SetAlarm(string time)
        {
            AlarmTime = time;
            Console.WriteLine($"Telefonun alarmı {AlarmTime} saatine kuruldu");
        }
        public void RingAlarm()
        {
            Console.WriteLine($"Telefonun alarmı {AlarmTime} saatinde çalıyor!");
        }

        public void StopAlarm()
        {
            Console.WriteLine("Telefon alarmı durduruldu");
        }
    }
}
