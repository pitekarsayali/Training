using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssingments
{
    class Multilevel
    {
        public void show1()
        {
            Console.WriteLine("Base Class");
        }
    }
    class Level2 : Multilevel
    {
        public void show2()
        {
            Console.WriteLine("Derived/Base Clase");
        }
    }
    class Level3 : Level2
    {
        public void show3()
        {
            Console.WriteLine("Derived Class");
            Console.ReadLine();
            
        }
        
    }
}
