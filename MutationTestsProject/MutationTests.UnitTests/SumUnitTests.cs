using System;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using MutationTests.Domain;
using Xunit;

namespace MutationTests.UnitTests
{
    public class SumUnitTests
    {
        private readonly Calculator _calculator;
        public SumUnitTests()
        {
            _calculator = new Calculator();
        }

        [Theory]
        [InlineData(1, 0, 1)]
        public void On_CalculatorSum_WhenSecondArgumentIsZero_ShouldCalculateProperly(int num1, int num2, int expected)
        {
            //Act
            var result = _calculator.Sum(num1, num2);
            //Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(1, 2, 4)]
        public void On_CalculatorSum_WhenSecondArgumentIsTwo_ShouldCalculateProperly(int num1, int num2, int expected)
        {
            //Act
            var result = _calculator.Sum(num1, num2);
            //Assert
            result.Should().NotBe(expected);
        }
    }
}
