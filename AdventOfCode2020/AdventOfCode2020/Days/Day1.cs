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
        private int desiredNumber = 2020;

        public override void PrepareData(string[] data)
        {
            expenseReport = Array.ConvertAll(data, s => int.Parse(s));
        }

        public override string Run()
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
                else //(sumResult > desiredNumber)
                {
                    leftIndex++;
                }
            }

            return "UNKNOWN";
        }
    }
}
