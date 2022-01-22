using Microsoft.AspNetCore.Mvc;

namespace RestWithASP_NET5.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
        private readonly ILogger<CalculadoraController> _logger;       
        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "sum/{firstNumber}/{secondNumber}")]
        public IActionResult Soma(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalido");

        }
        [HttpGet(Name = "sub/{firstNumber}/{secondNumber}")]
        public IActionResult Sub(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var Sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(Sub.ToString());
            }
            return BadRequest("Invalido");

        }
        [HttpGet(Name = "sMulti/{firstNumber}/{secondNumber}")]
        public IActionResult Multi(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var mult = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(mult.ToString());
            }
            return BadRequest("Invalido");

        }
        [HttpGet(Name = "Div/{firstNumber}/{secondNumber}")]
        public IActionResult Div(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var Div = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                return Ok(Div.ToString());
            }
            return BadRequest("Invalido");

        }
        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if(decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool IsNumber = double.TryParse(strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);
            return IsNumber;
        }
    }
}
