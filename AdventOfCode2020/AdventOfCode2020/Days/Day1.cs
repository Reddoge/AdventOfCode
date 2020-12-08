using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Days
{
    class Day1 : Day
    {
        private int[] expenseReport;
        private readonly int desiredNumber = 2020;

        public override void PrepareData(string[] data)
        {
            expenseReport = Array.ConvertAll(data, s => int.Parse(s));
        }

        public override string Run()
        {
            //Part 1 Code Execution
            stringBuilder.Append("Part 1 Answer: ").Append(RunPart1()).Append(' ', 5);

            TimeSpan part1Elapsed = stopwatch.Elapsed;
            stringBuilder.Append("Execution time:").AppendLine(part1Elapsed.ToString());


            //Part 2 Code Execution
            stringBuilder.Append("Part 2 Answer: ").Append(RunPart2()).Append(' ', 5);
            stringBuilder.Append("Execution time:").Append((stopwatch.Elapsed - part1Elapsed).ToString());

            return stringBuilder.ToString();
        }

        private string RunPart1()
        {
            Array.Sort(expenseReport);

            int leftIndex = 0;
            int rightIndex = expenseReport.Length - 1;

            while (leftIndex < rightIndex)
            {
                int sumResult = expenseReport[leftIndex] + expenseReport[rightIndex];

                if (sumResult == desiredNumber)
                {
                    return (expenseReport[leftIndex] * expenseReport[rightIndex]).ToString();
                }
                else if (sumResult > desiredNumber)
                {
                    rightIndex--;
                }
                else //(sumResult < desiredNumber)
                {
                    leftIndex++;
                }
            }

            return "UNKNOWN";
        }

        private string RunPart2()
        {
            return "";
        }
    }
}
