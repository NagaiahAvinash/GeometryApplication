using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary;

namespace GeometryTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestArea_Base10Height5_ExpectedArea25()
        {
            
            var triangle = new Triangle(10, 5, 3, 4, 5);

            
            var result = triangle.CalculateArea();

            
            Assert.AreEqual(25, result, 0.001, "Area calculation for triangle is incorrect.");
        }

        [TestMethod]
        public void TestPerimeter_Sides3_4_5_ExpectedPerimeter12()
        {
            
            var triangle = new Triangle(10, 5, 3, 4, 5);

            
            var result = triangle.CalculatePerimeter();

            
            Assert.AreEqual(12, result, 0.001, "Perimeter calculation for triangle is incorrect.");
        }
    }
}
