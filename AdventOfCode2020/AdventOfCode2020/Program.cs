using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            DataReader dataReader = new DataReader();

            for (int i = 1; i <= 25; i++)
            {
                Day day = null;
                string[] loadedData = dataReader.ReadData(i);

                if (loadedData is null) break;

                try
                {
                    day = Activator.CreateInstance(Type.GetType(String.Format("AdventOfCode2020.Days.Day{0}", i))) as Day;
                }
                catch (Exception)
                {
                    Console.WriteLine("Day{0}.cs file does not exist", i);
                    break;
                }

                day.PrepareData(loadedData);
                //Console.WriteLine("Running Day {0}", i);

                day.StartTimer();
                string answer = day.Run();
                day.StopTimer();

                Console.WriteLine("Day {0} output:" + Environment.NewLine + "{1}", i, answer);
                Console.WriteLine("The total execution: {0} \r\n", day.GetTotalElapsed());

            }

            Console.ReadLine();
        }
    }
}
