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

        public string GreaterLess(int num1, int num2)
        {
            return _greaterLessServices.GreaterLess(num1, num2);
        }
    }
}