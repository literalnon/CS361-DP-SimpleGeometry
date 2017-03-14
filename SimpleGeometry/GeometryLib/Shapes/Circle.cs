using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double r)
        {
            Debug.Assert(r > 0, "radius > 0");
            Radius = r;
        }
        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
        public override String Print()
        {
            double area = this.Area();
            return String.Format("Circle: radius = {0}, area = {1}", Radius, area);
        }
    }
}
