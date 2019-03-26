using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    class CircleClass
    {
        public void Area(int x)
        {
            int r = x;

            double area = 3.14 * r * r;
            Console.WriteLine("Area Of Circle is   " + area);
        }
    }
    class RectangleClass : CircleClass
    {
        public void Area(int x, int y)
        {
            int length = x;
            int width = y;

            int area = length * width;
            Console.WriteLine("Area Of rectangle is   " + area);
            Console.ReadLine();
        }
    }
}
