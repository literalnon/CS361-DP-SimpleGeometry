using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLib.Interface;

namespace GeometryLib.Shapes
{
    /// <summary>
    /// Абстрактный класс формы
    /// </summary>
    public abstract class Shape : IPrintable
    {
        public abstract String Print();
        public virtual double Area() { return 0; }
    }
}
