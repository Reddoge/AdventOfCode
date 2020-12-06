using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020
{
    abstract class Day
    {
        private Stopwatch stopwatch;

        public void StartTimer()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }

        public abstract void PrepareData(string[] data);

        public abstract string Run();

        public void StopTimer()
        {
            stopwatch.Stop();
        }

        public TimeSpan GetTotalElapsed()
        {
            return stopwatch.Elapsed;
        }
    }
}
