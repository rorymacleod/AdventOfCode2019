using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace AdventOfCode2019.Tests
{
    public class Day02Tests
    {
        [Theory]
        [InlineData(14, 2)]
        [InlineData(1969, 966)]
        [InlineData(100756, 50346)]
        public void Returns_fuel_for_known_masses_including_fuel_masses(int mass, int expected)
        {
            // Act
            var app = new Day02();
            app.AddMass(mass);

            app.Fuel.Should().Be(expected);
        }

        [Fact]
        public void Returns_fuel_for_combined_masses_with_fuel()
        {
            // Act
            var app = new Day02();
            app.AddMass(14);
            app.AddMass(1969);
            app.AddMass(100756);

            app.Fuel.Should().Be(2 + 966 + 50346);
        }
    }
}
