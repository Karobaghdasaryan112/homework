using homework.Shape;
using homework.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //area of Circle
            Circle circle = new Circle(4);
            Console.WriteLine(circle.CalculateArea());

            //area of Rectangle
            Rectangle rectangle = new Rectangle(4.23, 5.65);
            Console.WriteLine(rectangle.CalculateArea());

            Console.ReadLine();
        }
    }
}
