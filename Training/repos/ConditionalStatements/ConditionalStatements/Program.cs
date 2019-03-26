using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Operatrs op = new Operatrs();
            op.AritmaticOperators();
            op.LogicalOperators();
        }
    }
    class Operatrs
    {
        int x = 10;
        int y = 2;
        public void AritmaticOperators()
        {
            int add = x + y;
            Console.WriteLine("addioin is =" + add);

            int sub = x - y;
            Console.WriteLine("Substraction is =" + sub);

            if (x > y)
            {
                int remainder = x % y;
                Console.WriteLine("Modulos  Operation is =" + remainder);

                int div = x / y;
                Console.WriteLine("Division  Operation is =" + div);

            }
            if (y < x)
            {
                int mul = x * y;
                Console.WriteLine("multiplication is  Operation is =" + mul);
            }
            Console.WriteLine();
        }

        public void LogicalOperators()
        {
            int a = 10;
            int b = 20;
            int c = 30;

            if ((a <= b) && (a <= c))
            {
                Console.WriteLine("small no is =" + a);

            }
            if ((b <= a) && (b <= c))
            {
                Console.WriteLine("small no is =" + b);

            }
            if ((c <= a) && (c <= b))
            {
                Console.WriteLine("small no is =" + b);

            }
            Console.ReadLine();
        }
    }
}
