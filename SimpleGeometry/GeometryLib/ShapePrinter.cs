using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLib;
using GeometryLib.Shapes;
using GeometryLib.Interface;

namespace GeometryLib
{
    public static class ShapePrinter
    {
        public static void Print(IPrintable shape)
        {
            String StringToPrint = shape.Print();
            Console.WriteLine(StringToPrint);
        }
    }
}
