using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAlarmSystem
{
    internal interface IAlarm
    {
        void SetAlarm(string time);
        void RingAlarm();
        void StopAlarm();
    }
}
