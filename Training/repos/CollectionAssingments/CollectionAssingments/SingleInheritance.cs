using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssingments
{
    class SingleInheritance
    {
        public void display()
        {
            Console.WriteLine("Base Class");
        }

    }
    class B : SingleInheritance
    {
        public void display2()
        {
            Console.WriteLine("Derived Class");
            Console.ReadLine();
        }
        
    }
    
}
