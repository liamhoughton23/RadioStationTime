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
        /*public string DisplayTime()
        {
            string gettingTime = Time();
            Console.WriteLine(gettingTime);
        }*/
        string Radio()
        {
            Console.WriteLine("What radio staion do you want?");
            string answer = Console.ReadLine();
            return answer;
        }
        /*public void DisplayRadio()
        {
            string gettingRadio = Radio();
            Console.WriteLine(gettingRadio)
        }*/
        string AlarmClock()
        {
            Console.WriteLine("What time do you want to set an alarm to?");
            string alarmTime = Console.ReadLine();
            float.Parse(alarmTime);
            return alarmTime;
        }
        public void DisplayEverything()
        {
            string gettingTime = Time();
            Console.WriteLine(gettingTime);
            string gettingRadio = Radio();
            Console.WriteLine("This Staion is playing: ", gettingRadio);
            string gettingAlarmClock = AlarmClock();
            Console.WriteLine("You the alarm to go off at this time: ", gettingAlarmClock);
        }
    }
}
