using System;
using System.Collections.Generic;
using System.Text;

namespace Mag.Tech.LookAndSay
{
    public class LookAndSayParser
    {
        public long LookAndSay(long n)
        {
            if(n < 0)
            {
                throw new ArgumentException("Input parameter must be positive number.");
            }

            var result = new StringBuilder();

            foreach (var group in Parse(n.ToString()))
            {
                result.Append(group.ToString());
            }

            return long.Parse(result.ToString());
        }

        private IEnumerable<DigitGroup> Parse(string input)
        {
            DigitGroup currentGroup = new DigitGroup(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                var digit = input[i];
                if (currentGroup.Digit != digit)
                {
                    yield return currentGroup;
                    currentGroup = new DigitGroup(digit);
                }
                else
                {
                    currentGroup.Increment();
                }
            }

            yield return currentGroup;
        }
    }
}
