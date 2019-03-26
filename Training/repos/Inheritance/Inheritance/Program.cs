using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //SingleInheritance2 s = new SingleInheritance2();
            //s.display();
            //s.show();

            //Message mobilePhone = new Message();
            //mobilePhone.displayMessage();


            //Shape s2 = new Shape();
            //s2.drow();
            //Shape s = new Rect();
            //s.drow();
            //Shape s1 = new Circle();
            //s1.drow();

            RectangleClass r = new RectangleClass();
            r.Area(2);
            r.Area(5, 4);


        }
    }


    public class SingleInheritance
    {
        public int a = 10;

        public void display()
        {
            Console.WriteLine("Value of a is=" + a);
      


        }
    }
    public class SingleInheritance2 : SingleInheritance
    {
        public int b = 20;

        public void show()
        {
            Console.WriteLine("Value of b is=" + b);
            Console.ReadLine();
        }

    }

}
