using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Intermediate_Udemy
{
    class Stopwatch
    {
        TimeSpan duration;
        bool stopwatchStarted;
        DateTime begin;
        DateTime end;

        public Stopwatch()
        {
            stopwatchStarted = false;

        }

        public void start()
        {
            if (stopwatchStarted)
            {
                throw new InvalidOperationException("Cannot start watch twice");
            }
            Console.WriteLine("Starting stopwatch");
            begin = DateTime.Now;
            stopwatchStarted = true;
        }
        public void stop()
        {
            if (!stopwatchStarted)
            {
                throw new InvalidOperationException("Cannot stop watch twice");
            }
            Console.WriteLine("Stopping stopwatch");
            duration =  DateTime.Now - begin;
            stopwatchStarted = false;
            Console.WriteLine("Duration is {0}", duration);

        }
    }
}
