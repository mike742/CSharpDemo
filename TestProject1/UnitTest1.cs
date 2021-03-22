using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpDemo;

namespace TestProject1
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
            string res = Program.PrimeFactors(number);
            string expected = "2 x 2";

            // Assert
            Assert.AreEqual(res, expected);
        }
    }
}
