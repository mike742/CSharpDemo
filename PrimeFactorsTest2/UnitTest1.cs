using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpDemo;

namespace PrimeFactorsTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int number = 4;

            // Act
            string expected = "2 2 ";
            string res = Program.PrimeFactors(number);

            // Assert
            Assert.AreEqual(expected, res);
        }
    }
}
