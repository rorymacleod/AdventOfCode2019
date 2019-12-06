using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Day02();
        }

        private static void Day01()
        {
            var day = new Day01();
            var masses = File.ReadAllLines(".\\Data\\Day01.txt")
                .Select(int.Parse)
                .ToArray();
            long fuel = day.GetFuel(masses);

            Console.WriteLine($"Fuel: {fuel}");
        }

        private static void Day02()
        {
            var day = new Day02();
            var masses = File.ReadAllLines(".\\Data\\Day01.txt")
                .Select(int.Parse);
            foreach (var mass in masses)
            {
                day.AddMass(mass);
            }


            Console.WriteLine($"Fuel: {day.Fuel}");
        }
    }
}
