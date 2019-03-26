using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = Enumerable.Range(1, 100).ToList();
            var List1 = Enumerable.Range(1, 100).ToList();
            var List2 = Enumerable.Range(1, 100).ToList();

            Console.WriteLine("even no are");
            foreach (int i in List)
            {
                if (i % 2 == 0)
                {


                    Console.WriteLine(i);
                }
            }

            

            Console.WriteLine();
            Console.WriteLine("odd no are");

            foreach (int j in List)
            {
                if (j % 2 == 1)
                {
                    Console.WriteLine(j);
                }
            }
           

          
            

            


            Console.ReadLine();
        }
        
    }
}
