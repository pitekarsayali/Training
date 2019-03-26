using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssingments
{
    class Hirachical
    {
        public void get1()
        {
            Console.WriteLine("Super Clase");
        }


    }
    class A : Hirachical
    {
        public void get2()
        {
            Console.WriteLine("First Base Clase");
        } 
    }

    class C : Hirachical
    {
        public void get3()
        {
            Console.WriteLine("Second Base Clase");
            Console.ReadLine();
        }

    }
}
