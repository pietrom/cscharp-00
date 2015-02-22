using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp00
{
    interface Polygon
    {
        int getArea();
        int getPerimeter();
    }

    class Rectangle : Polygon
    {
        private int x, y;
        public Rectangle(int x, int y)
        {
            this.x = x; this.y = y;
        }

        public int getArea()
        {
            return x * y;
        }

        public int getPerimeter()
        {
            return 2 * (x + y);
        }
    }

    class Square : Rectangle
    {
        public Square(int x) : base(x, x) { }
    }

    interface I1
    {
        string foo();
    }


    interface I2
    {
        int foo();
    }

    class C : I1, I2
    {
        string I1.foo()
        {
            return "FOO1";
        }

        int I2.foo()
        {
            return 2;
        }
    }
    [TestClass]
    public class InheritanceTest
    {
        [TestMethod]
        public void RectangleIsAPolygon()
        {
            Polygon p = new Rectangle(10, 20);
            Assert.AreEqual(200, p.getArea());
            Assert.AreEqual(60, p.getPerimeter());
        }
        [TestMethod]
        public void SquareIsARectangle()
        {
            Rectangle r = new Square(10);
            Assert.AreEqual(100, r.getArea());
            Assert.AreEqual(40, r.getPerimeter());
        }

        [TestMethod]
        public void MultipleInterfaceWithMethodCollision()
        {
            I1 i1 = new C();
            Assert.AreEqual("FOO1", i1.foo());
            I2 i2 = new C();
            Assert.AreEqual(2, i2.foo());
        }
    }
}
