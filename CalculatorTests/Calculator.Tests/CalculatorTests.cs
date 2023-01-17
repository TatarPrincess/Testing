using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalShouldReturnCorrectValue() 
        {
          Calculator calculator= new Calculator();
            Assert.True(14 == calculator.Additional(10, 4));

        }
        [Test]
        public void SubtractionShouldReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.True(11 == calculator.Subtraction(15, 4));

        }
        [Test]
        public void MiltiplicationShouldReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.True(60 == calculator.Miltiplication(15, 4));

        }
        [Test]
        public void DivisionShouldReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.True(3 == calculator.Division(15, 5));

        }
    }
}
