using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpacekKMCTwoToFour.Services
{
    public class AddTwoNumbersServices
    {
       
        public string AddTwoNumbers(int num1, int num2)
        {
            string sum = $"{num1} added to {num2} equals {num1 + num2}.";
            return sum;

        }
    }
}