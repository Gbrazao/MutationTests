using Microsoft.AspNetCore.Mvc;
using MutationTests.Domain;

namespace MutationTests.API.Controllers
{
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculator _calculator;
        public CalculatorController(ICalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpGet("Sum")]
        public int Sum([FromQuery] int num1, [FromQuery] int num2)
        {
            return _calculator.Sum(num1, num2);
        }

    }
}