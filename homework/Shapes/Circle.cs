using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.Shape
{
    internal class Circle : shape
    {
        private const double _pi = 3.14;
        private readonly double _radius;
        public Circle(double Radius)
        {
            _radius = Radius;
        }
        public override double CalculateArea()
        {
            return _pi * _radius * _radius;
        }
    }
}
