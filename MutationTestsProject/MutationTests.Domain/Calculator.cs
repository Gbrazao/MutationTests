using System;
using System.Linq;

namespace MutationTests.Domain
{
    public class Calculator : ICalculator
    {
        /// <summary>
        /// Method responsible to perform a sum between two numbers
        /// </summary>
        /// <param name="num1">The first number in the sum.</param>
        /// <param name="num2">The second number in the sum.</param>
        /// <returns></returns>
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        

        /// <summary>
        /// Method responsible to define the limits based on 0-999
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int DefineLimits(int value)
        {
            if (value < 0) return 0;
            if (value > 999) return 999;

            return value;
        }

    }
}
