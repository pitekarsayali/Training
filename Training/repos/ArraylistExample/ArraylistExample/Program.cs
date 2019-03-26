using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArraylistExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            
            for (int i = 0; i < 5; i++)
            {
                Emp e = new Emp();

                Console.WriteLine("Enter id");
                e.Id= Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter name");
                e.Name = Console.ReadLine();

                Console.WriteLine("Enter salary");
                e.salary = Convert.ToInt32(Console.ReadLine());


                a1.Add(e);
            }

            //foreach(Emp ob in a1)
            //{
            //    Console.WriteLine(ob.Id);
            //    Console.WriteLine(ob.Name);
            //    Console.WriteLine(ob.salary);
            //}
            


            //Emp e = new Emp();

            int[] topTen = new int[5];

            for (int j = 0; j < topTen.Length; j++)
            {
                topTen[j] = ((Emp)a1[j]).salary;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (topTen[j] < topTen[i])
                    {
                       int tmp = topTen[i];
                        topTen[i] = topTen[j];
                        topTen[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                foreach (Emp ob in a1)
                 {
               
                    if(ob.salary == topTen[i])
                    {
                        Console.Write("sorted values");
                        Console.WriteLine(ob.Id+"\n");
                        Console.WriteLine(ob.Name + "\n");
                        Console.WriteLine(ob.salary + "\n");
                    }

                }
                Console.ReadLine();
            }


                //Console.WriteLine("\nEnter Employee Id:\n");
                //int eid = Convert.ToInt32(Console.ReadLine());


                //for (int i = 0; i < 3; i++)
                //{
                //    if (topTen[i] == eid)
                //    {
                //        Console.WriteLine(Id);
                //        Console.WriteLine(ob.Name);
                //        Console.WriteLine(ob.salary);
                //    }

                //}



            }
            
    }


    class Emp
    {
        public int Id;
        public String Name;
        public int salary;
    }
}
