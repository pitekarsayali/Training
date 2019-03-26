using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class DatatypeConversion
    {
        public void Display()
        {
            int a = 20;
            long l = a;//boxing
            int c = (int)l;//unboxing
            Console.WriteLine(l);
            Console.WriteLine(c);
            Console.ReadLine();


        }
        public void dis()
        {
            int num=10;
            switch (num)
            {
                case 10: Console.WriteLine("It is 10"); break;
                case 20: Console.WriteLine("It is 20"); break;
                case 30: Console.WriteLine("It is 30"); break;
                default: Console.WriteLine("Not 10, 20 or 30"); break; 
            }

        }

}
}
