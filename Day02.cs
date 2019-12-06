using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2019
{
    public class Day02
    {
        public long Fuel { get; private set; }

        public void AddMass(int mass)
        {
            if (mass <= 0)
                return;

            int fuel = GetFuel(mass);
            if (fuel > 0)
            {
                this.Fuel += fuel;
                this.AddMass(fuel);
            }
        }

        private static int GetFuel(int mass)
        {
            int fuel = (mass / 3) - 2;
            return fuel;
        }
    }
}
