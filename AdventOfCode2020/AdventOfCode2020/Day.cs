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
        protected Stopwatch stopwatch;
        protected StringBuilder stringBuilder;

        public Day()
        {
            stringBuilder = new StringBuilder();
            stopwatch = new Stopwatch();
        }

        public void StartTimer()
        {
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
