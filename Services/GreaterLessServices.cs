using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpacekKMCTwoToFour.Services
{
    public class GreaterLessServices
    {
        public string GreaterLess(int firstNum, int secondNum)
        {
            string greaterLessStr = "";
            if(firstNum > secondNum)
            {
                greaterLessStr = $"{firstNum} is greater than {secondNum}. {secondNum} is less than {firstNum}.";
            }else if(firstNum< secondNum)
            {
                greaterLessStr = $"{secondNum} is greater than {firstNum}. {firstNum} is less than {secondNum}.";
            }else if(firstNum == secondNum)
            {
                greaterLessStr = $"{firstNum} and {secondNum} are equal.";
            }

            return greaterLessStr;
        }
    }
}