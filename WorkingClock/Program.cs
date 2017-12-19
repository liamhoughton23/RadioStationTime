using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock radio = new Clock();
            radio.DisplayEverything();
            Console.ReadKey();

        }
    }
}
