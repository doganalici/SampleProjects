using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAlarmSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAlarm alarm1 = new DigitalClock();
            alarm1.SetAlarm("07:30");
            alarm1.RingAlarm();
            alarm1.StopAlarm();

            Console.WriteLine("\n*****************************\n");
            IAlarm alarm2 = new DigitalClock();
            alarm2.SetAlarm("09:00");
            alarm2.RingAlarm();
            alarm2.StopAlarm();

            Console.WriteLine("\n*****************************\n");

            IAlarm phoneAlarm1 = new Smartphone();
            phoneAlarm1.SetAlarm("06:45");
            phoneAlarm1.RingAlarm();
            phoneAlarm1.StopAlarm();

            Console.WriteLine("\n*****************************\n");

            IAlarm phoneAlarm2 = new Smartphone();
            phoneAlarm2.SetAlarm("08:15");
            phoneAlarm2.RingAlarm();
            phoneAlarm2.StopAlarm();

        }
    }
}
