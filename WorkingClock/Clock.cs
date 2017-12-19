using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingClock
{
    class Clock
    {
        public string Time()
        {
            string date = DateTime.Now.ToString("h:mm:ss tt");
            return date;
        }
        public void DisplayTime()
        {
            string gettingTime = Time();
            Console.WriteLine(gettingTime);
            Console.ReadKey();

        }
  
    }
}
