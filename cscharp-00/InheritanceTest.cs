using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace csharp00
{
    interface Polygon
    {
        int getArea();
        int getPerimeter();
    }

    class MockPolygon : Polygon
    {
        private int area, perimeter;
        public MockPolygon(int area, int perimeter)
        {
            this.area = area;
            this.perimeter = perimeter;
        }

        public int getArea()
        {
            return area;
        }

        public int getPerimeter()
        {
            return perimeter;
        }
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
            return "FOO" + foo();
        }

        int I2.foo()
        {
            return foo() + foo();
        }

        int foo()
        {
            return 1;
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
        public void MockPolygon()
        {
            Polygon p = new MockPolygon(100, 50);
            Assert.AreEqual(100, p.getArea());
            Assert.AreEqual(50, p.getPerimeter());
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

        [TestMethod]
        public void Polymorphism()
        {
            IList<Polygon> list = new List<Polygon>();
            list.Add(new Rectangle(10, 20));
            list.Add(new MockPolygon(20, 20));
            list.Add(new MockPolygon(30, 30));
            int at = 0;
            int pt = 0;
            foreach(Polygon p in list)
            {
                at += p.getArea();
                pt += p.getPerimeter();
            }
            Assert.AreEqual(250, at);
            Assert.AreEqual(110, pt);
        }
    }
}
