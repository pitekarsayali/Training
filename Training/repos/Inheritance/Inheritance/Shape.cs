using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Shape
    {
        virtual public void drow()                            //function overriding
        {
            Console.WriteLine("Shape Drow...");
        }
    }
    public class Rect : Shape
    {
        public override void drow()
        {

            Console.WriteLine("Rect Drow......");
        }
    }
    public class Circle : Shape
    {
        public override void drow()
        {

            Console.WriteLine("Circle Drow......");
            Console.ReadLine();
        }
    }
}

