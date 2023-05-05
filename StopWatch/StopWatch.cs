using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime startTime;
        private DateTime stopTime;
        private bool running = false;

        public void Start()
        {
            this.startTime = DateTime.Now;
            this.running = true;
        }

        public void Stop()
        {
            this.stopTime = DateTime.Now;
            this.running = false;
        }

        public TimeSpan GetElapsedTime()
        {
            TimeSpan elapsed;
            if (running)
                elapsed = DateTime.Now - startTime;
            else
                elapsed = stopTime - startTime;
            return elapsed;
        }

    }
}
