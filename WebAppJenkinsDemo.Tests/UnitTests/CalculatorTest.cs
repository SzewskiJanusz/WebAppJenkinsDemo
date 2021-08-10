using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppJenkinsTest.Logic;

namespace WebAppJenkinsDemo.Tests.UnitTests
{
    [TestFixture]
    public class CalculatorTest
    {
        private ICalculatorLogic _calculatorLogic;
        [SetUp]
        public void SetUp()
        {
            _calculatorLogic = new CalculatorLogic();
        }

        [Test]
        public void IsEven_InputIs5_ReturnFalse()
        {
            var result = _calculatorLogic.IsEven(5);

            Assert.IsFalse(result, "5 nie jest parzyste");
        }
    }
}
