using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpacekKMCTwoToFour.Services;

namespace SpacekKMCTwoToFour.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreaterLessController : ControllerBase
    {
        private readonly GreaterLessServices _greaterLessServices;
        public GreaterLessController(GreaterLessServices greaterLessServices){
            _greaterLessServices = greaterLessServices;
        }

        [HttpGet]
        [Route("Compare/{num1}/{num2}")]

        public string GreaterLess(int firstNum, int secondNum)
        {
            return _greaterLessServices.GreaterLess(firstNum, secondNum);
        }
    }
}