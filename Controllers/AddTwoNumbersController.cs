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
    public class AddTwoNumbersController : ControllerBase
    {
        private readonly AddTwoNumbersServices _addTwoNumbersServices;
        public AddTwoNumbersController(AddTwoNumbersServices addTwoNumbersServices){
            _addTwoNumbersServices = addTwoNumbersServices;
        }

        [HttpGet]
        [Route("Add/{num1}/{num2}")]
        public string AddTwoNumbers(int num1, int num2)
        {
            return _addTwoNumbersServices.AddTwoNumbers(num1, num2);
        }

    }
}