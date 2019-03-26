using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCode
{
    class Multiple
    {
        public void display()
        {
            Console.WriteLine("super class1");
        }
    }
    class A1
    {
        public void display()
        {
            Console.WriteLine("super class2");

        }
    }
    class B1 : Multiple, A1
    {

    }
}
