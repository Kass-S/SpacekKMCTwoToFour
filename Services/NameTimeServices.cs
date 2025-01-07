using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpacekKMCTwoToFour.Services
{
    public class NameTimeServices
    {
        public string NameTime(string name, string time)
        {
            string nameTimeStr = $"Hello {name}! You woke up at {time} today.";
            return nameTimeStr;
        }
    }
}