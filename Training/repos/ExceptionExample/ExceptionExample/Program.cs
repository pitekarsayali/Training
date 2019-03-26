using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArithmaticOperation;

namespace ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Enter 1st no:\n");
            //    int a = Convert.ToInt32(Convert.ToInt32(Console.ReadLine()));

            //    Console.WriteLine("Enter 2nd no:\n");
            //    int b = Convert.ToInt32(Convert.ToInt32(Console.ReadLine()));
            //    Operation o = new Operation();
            //    try
            //    {
            //        int c = o.Divide(a, b);

            //        Console.WriteLine("result is");
            //        Console.WriteLine(c);
            //        Console.WriteLine(" Program Completed");

            //    }
            //    catch (Exception e)
            //    {
            //        //Console.WriteLine(e.InnerException);
            //        //Console.WriteLine("Error is here...");
            //        Console.WriteLine(e.Message);

            //    }
            //    Console.ReadLine();
            //}

            Operation o = new Operation();

            Console.WriteLine("Enter no:\n");
            int a = Convert.ToInt32(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(a);

            o.Change(ref a);

            
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
