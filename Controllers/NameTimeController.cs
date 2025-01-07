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
    public class NameTimeController : ControllerBase
    {
        private readonly NameTimeServices _nameTimeServices;
        public NameTimeController(NameTimeServices nameTimeServices){
            _nameTimeServices = nameTimeServices;
        }

        [HttpGet]
        [Route("Greet/{name}/{time}")]
        public string NameTime(string name, string time)
        {
            return _nameTimeServices.NameTime(name, time);
        }
    }
}