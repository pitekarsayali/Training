using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> l = new List();


            //for (int i=1; i <= 100; i++)
            //{
            //    l.Add(i);
            //}

            //Console.WriteLine("Even no");
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (l[i]%2 == 0)
            //    {

            //        Console.WriteLine(l[i]);
            //    }
            //}

            //;



            var List = Enumerable.Range(1, 100).ToList();
            var List1 = Enumerable.Range(1, 100).ToList();

            for (int i = 0; i <= 100; i++)
            {
                if (List[i] % 2 == 0)
                {
                   

                    

                    List1.Add(List[i]);



                }

            }

            foreach (var i in List1)
            {
                Console.WriteLine(i);
            }
                
            Console.ReadKey();
        }
        


    }

    
}
