using HW16;
using NUnit.Framework;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();

        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            
            int actual = calculator.Additional(20, 4);
            int expected = 24;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubstractionMustReturnCorrectValue()
        {

            int actual = calculator.Subtraction(45, 9);
            int expected = 36;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MiltiplicationMustReturnCorrectValue()
        {
            int actual = calculator.Miltiplication(5, 12);
            int expected = 60;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            
            int actual = calculator.Division(90, 3);
            int expected = 30;

            Assert.AreEqual(expected, actual);
        }
    }
}
