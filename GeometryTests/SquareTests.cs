using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;

namespace GeometryTests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void TestArea_Side5_ExpectedArea25()
        {
            
            var square = new Square(5);

            
            var result = square.CalculateArea();

            
            Assert.AreEqual(25, result, 0.001, "Area calculation for square is incorrect.");
        }

        [TestMethod]
        public void TestPerimeter_Side5_ExpectedPerimeter20()
        {
            
            var square = new Square(5);

            
            var result = square.CalculatePerimeter();

            
            Assert.AreEqual(20, result, 0.001, "Perimeter calculation for square is incorrect.");
        }
    }
}
