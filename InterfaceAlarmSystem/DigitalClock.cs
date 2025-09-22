using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAlarmSystem
{
    public class DigitalClock : IAlarm
    {
        public string AlarmTime { get; set; }


        public void SetAlarm(string time)
        {
            AlarmTime = time;
            Console.WriteLine($"Alarm {AlarmTime} saatine kuruldu");
        }
        public void RingAlarm()
        {
            Console.WriteLine($"Alarm {AlarmTime} saatinde çalıyor!");
        }

        public void StopAlarm()
        {
            Console.WriteLine("Dijital saat alarmı durduruldu");
        }
    }
}
