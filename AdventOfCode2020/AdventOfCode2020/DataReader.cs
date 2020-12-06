using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020
{
    class DataReader
    {
        public DataReader()
        {
            
        }

        public string[] ReadData(int dayNumber)
        {
            string targetDayFile = String.Format("Data\\Day{0}.txt", dayNumber);

            if(File.Exists(targetDayFile))
            {
                return File.ReadAllLines(targetDayFile);
            }

            return null;
        }
    }
}
