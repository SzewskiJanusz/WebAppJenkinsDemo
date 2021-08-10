using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppJenkinsTest.Logic
{
    public class CalculatorLogic : ICalculatorLogic
    {
        public bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }
}