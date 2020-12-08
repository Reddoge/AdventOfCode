using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Days
{
    class Day3 : Day
    {
        private readonly int xMovement = 3;
        private readonly int yMovement = 1;

        private string[] tobogganMap;

        public override void PrepareData(string[] data)
        {
            tobogganMap = data;
        }

        public override string Run()
        {
            int x = 0;
            int y = 0;
            int numOfEncounteredTrees = 0;

            while (y < tobogganMap.Length)
            {
                if(tobogganMap[y][x] == '#')
                {
                    numOfEncounteredTrees++;
                }

                x = (x + xMovement) % tobogganMap[y].Length;
                y += yMovement;
            }

            stringBuilder.Append("Part 1 Answer: ").Append(numOfEncounteredTrees).Append(' ', 5);
            return stringBuilder.ToString();
        }
    }
}
