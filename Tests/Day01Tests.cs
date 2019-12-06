using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2019.Tests
{
    public class Day01Tests
    {
        [Theory]
        [InlineData(12, 2)]
        [InlineData(14, 2)]
        [InlineData(1969, 654)]
        [InlineData(100756, 33583)]
        public void Returns_fuel_for_known_masses(int mass, int expected)
        {
            // Act
            var app = new Day01();
            long fuel = app.GetFuel(mass);

            fuel.Should().Be(expected);
        }

        [Fact]
        public void Returns_fuel_for_combined_masses()
        {
            // Act
            var app = new Day01();
            long fuel = app.GetFuel(12, 14, 1969);

            fuel.Should().Be(2 + 2 + 654);
        }
    }
}
