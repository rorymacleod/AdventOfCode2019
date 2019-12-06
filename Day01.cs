using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2019
{
    public class Day01
    {
        public long GetFuel(params int[] masses)
        {
            long total = 0;
            foreach (var mass in masses)
            {
                int fuel = (mass / 3) - 2;
                total += fuel;
            }

            return total;
        }
    }
}
