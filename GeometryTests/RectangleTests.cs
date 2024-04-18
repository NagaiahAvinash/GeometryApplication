using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;

namespace GeometryTests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void TestArea_Length6Width2_ExpectedArea12()
        {
            
            var rectangle = new Rectangle(6, 2);

            
            var result = rectangle.CalculateArea();

            
            Assert.AreEqual(12, result, 0.001, "Area calculation for rectangle is incorrect.");
        }

        [TestMethod]
        public void TestPerimeter_Length6Width2_ExpectedPerimeter16()
        {
            
            var rectangle = new Rectangle(6, 2);

            
            var result = rectangle.CalculatePerimeter();

            
            Assert.AreEqual(16, result, 0.001, "Perimeter calculation for rectangle is incorrect.");
        }
    }
}
