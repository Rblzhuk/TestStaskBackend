using GeometricShapeAreaSearchLibrary;

namespace ShapeAreaLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PositiveCircleAreaTest()
        {
            double expected = Math.PI * 5 * 5;

            Circle circle = new Circle(5);
            Assert.AreEqual(expected, circle.GetArea());
        }
        [TestMethod]
        public void PositiveTriangleAreaTest()
        {
            double expected = 11.62;

            Triangle triangle = new Triangle(4,6,8,40,60,80);
            Assert.AreEqual(expected, Math.Round(triangle.GetArea(),2));
        }
        [TestMethod]
        public void PositiveIsRightAngledTriangleTest()
        {
            bool expected = true;

            Triangle triangle = new Triangle(3, 4, 5, 36.87, 53.13, 90);
            Assert.AreEqual(expected, triangle.IsRightAngled());
        }
        [TestMethod]
        public void NegativeIsRightAngledTriangleTest()
        {
            bool expected = false;

            Triangle triangle = new Triangle(4, 6, 8, 40, 60, 80);
            Assert.AreEqual(expected, triangle.IsRightAngled());
        }
    }
}