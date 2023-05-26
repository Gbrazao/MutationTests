using System;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using MutationTests.Domain;
using Xunit;

namespace MutationTests.UnitTests
{
    public class CalculatorUnitTests
    {
        private readonly Calculator _calculator;
        public CalculatorUnitTests()
        {
            _calculator = new Calculator();
        }

        [Theory]
        [InlineData(1000, 999)]
        [InlineData(-11, 0)]
        [InlineData(35, 35)]
        public void On_CalculatorSum_WhenSecondArgumentIsZero_ShouldCalculateProperly(int value, int expected)
        {
            //Act
            var result = _calculator.DefineLimits(value);
            //Assert
            result.Should().Be(expected);
        }
    }
}
