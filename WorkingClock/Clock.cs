using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingClock
{
    class Clock
    {
        string Time()
        {
            string date = DateTime.Now.ToString("h:mm:ss tt");
            return date;
        }
        string Radio()
        {
            Console.WriteLine("What radio staion do you want?");
            string answer = Console.ReadLine();
            return answer;
        }
        string AlarmClock()
        {
            Console.WriteLine("What time do you want to set an alarm to? DONT ADD AM OR PM");
            string alarmTime = Console.ReadLine();
            float.Parse(alarmTime);
            return alarmTime;
        }
        string AlarmAmPm()
        {
            Console.WriteLine("AM or PM?");
            string pmam = Console.ReadLine();
            return pmam;
        }
        public void DisplayEverything()
        {
            string gettingTime = Time();
            Console.WriteLine(gettingTime);
            string gettingRadio = Radio();
            Console.WriteLine("This Staion is playing: "); 
            Console.WriteLine(gettingRadio);
            string gettingAlarmClock = AlarmClock();
            string gettingAmPm = AlarmAmPm();
            Console.WriteLine("You the alarm to go off at this time: ");
            Console.WriteLine(gettingAlarmClock + gettingAmPm);

        }
    }
}
