using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpDemo;

namespace PrimeFactorsTest
{
    [TestClass]
    public class UnitTest1
    {
        // Prime factors of 4 are: "2 2 "
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

        //Prime factors of 7 are: 7
        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            int number = 7;

            // Act
            string expected = "7 ";
            string res = Program.PrimeFactors(number);

            // Assert
            Assert.AreEqual(expected, res);
        }
    }
}
