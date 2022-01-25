using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pluralsight.UnitTestDemo.Api;

namespace Pluralsight.UnitTestDemo.Tests
{
    [TestClass]
    public class CalculatorFixture
    {
        [TestMethod]
        public void Add()
        {
            // arrange
            int value1 = 2;
            int value2 = 3;
            int expected = 5;

            // act
            var sut = new Calculator();

            int actual = sut.Add(value1, value2);

            // assert
            Assert.AreEqual<int>(expected, actual, "Wrong result");
        }
    }
}
