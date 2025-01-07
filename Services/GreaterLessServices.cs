using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpacekKMCTwoToFour.Services
{
    public class GreaterLessServices
    {
        public string GreaterLess(int num1, int num2)
        {
            string greaterLessStr = "";
            if(num1 > num2)
            {
                greaterLessStr = $"{num1} is greater than {num2}. {num2} is less than {num1}.";
            }else if(num1 < num2)
            {
                greaterLessStr = $"{num2} is greater than {num1}. {num1} is less than {num2}.";
            }else if(num1 == num2)
            {
                greaterLessStr = $"{num1} and {num2} are equal.";
            }

            return greaterLessStr;
        }
    }
}