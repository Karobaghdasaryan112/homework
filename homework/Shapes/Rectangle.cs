using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.Shapes
{
    internal class Rectangle : shape
    {
        private readonly double _a;
        private readonly double _b;
        public Rectangle(double A,double B)
        {
            _a = A;
            _b = B;
        }
        public override double CalculateArea()
        {
            return _a * _b;
        }
    }
}
