using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    /// <summary>
    /// Произвольный треугольник
    /// </summary>
    public class Triangle : Shape
    {
        // Длины сторон треугольника
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public Triangle(double side1, double side2, double side3)
        {
            Debug.Assert(side1 > 0, "side1 > 0");
            Debug.Assert(side2 > 0, "side2 > 0");
            Debug.Assert(side3 > 0, "side3 > 0");
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public override double Area()
        {
            var p = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }
        public override String Print()
        {
            double area = this.Area();
            return String.Format("Triangle: sides: {0} {1} {2}, area = {3}", Side1, Side2, Side3, area);
        }
    }
}
