using System;

namespace AdventOfCode2021
{
    public class Day2
    {
        public Day2()
        {

        }

        public void Go()
        {
            int horizontal = 0;
            int depth = 0;
            int aim = 0;

            string[] lines = System.IO.File.ReadAllLines(@"C:\Git\AdventOfCode2021\AdventOfCode2021\AdventOfCode2021\day2data.txt");
            foreach(var line in lines)
            {
                var val = ParseLine(line);

                if(line.StartsWith("forward"))
                {
                    horizontal += val;
                    depth = depth + (aim * val);
                }
                else if(line.StartsWith("down"))
                {
                   // depth += val;
                    aim += val;
                }
                else if (line.StartsWith("up"))
                {
                    //depth -= val;
                    aim -= val;
                }
            }

            Console.WriteLine(horizontal * depth);
        }

        private int ParseLine(string line)
        {
            return int.Parse(line.Replace("forward ", "").Replace("up ", "").Replace("down ", ""));
        }
    }
}
