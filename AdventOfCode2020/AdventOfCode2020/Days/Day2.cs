using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Days
{
    class Day2 : Day
    {
        private readonly string[] splitByStrings = { "-", " ", ":" };

        private int[] minCharacterPolicyCount;
        private int[] maxCharacterPolicyCount;

        private char[] characterPolicies;
        private string[] passwords;

        public override void PrepareData(string[] data)
        {
            minCharacterPolicyCount = new int[data.Length];
            maxCharacterPolicyCount = new int[data.Length];
            characterPolicies = new char[data.Length];
            passwords = new string[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                string[] splitData = data[i].Split(splitByStrings, StringSplitOptions.RemoveEmptyEntries);

                minCharacterPolicyCount[i] = Convert.ToInt32(splitData[0]); //Retrieving minimum character count
                maxCharacterPolicyCount[i] = Convert.ToInt32(splitData[1]); //Retrieving maximum character count
                characterPolicies[i] = splitData[2][0];
                passwords[i] = splitData[3];
            }
        }

        public override string Run()
        {
            int numberOfValidPasswords = 0;

            for (int i = 0; i < passwords.Length; i++)
            {
                int policyCharacterCount = passwords[i].ToCharArray().Count(c => c == characterPolicies[i]);

                if(policyCharacterCount >= minCharacterPolicyCount[i] && policyCharacterCount <= maxCharacterPolicyCount[i])
                {
                    numberOfValidPasswords++;
                }
            }

            stringBuilder.Append("Part 1 Answer: ").Append(numberOfValidPasswords).Append(' ', 5);

            TimeSpan part1Elapsed = stopwatch.Elapsed;
            stringBuilder.Append("Execution time:").AppendLine(part1Elapsed.ToString());

            return stringBuilder.ToString();
        }
    }
}
