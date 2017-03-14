using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    public class Square : Shape
    {
        public double Side { get; }

        public Square(double side) { this.Side = side; }

        public override double Area()
        {
            return Side * Side;
        }

        public override String Print()
        {
            double area = this.Area();
            return String.Format("Square: sides = {0}, area = {1}", Side, area);
        }
    }
}
