using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Studetails d = new Studetails();


            IList<Student> StudList1 = d.Getdata();

            //basic linq
            var item = from i in StudList1
                       select i;

            Console.WriteLine(item.FirstOrDefault(x => x.fname.Contains("sayali")).fname);//contains =it will check if conditions
            Console.WriteLine(item.LastOrDefault(x => x.lname.Contains("shewale")).lname);

            //concat
            //IList<int> intList1 = new List<int>(){10,21,30,45};
            //IList<int> intList2 = new List<int>() { 67, 21, 30, 45 };

            //var list3 = intList1.Concat(intList2);
            //foreach(var i in list3)
            //{
            //    Console.WriteLine(i);
            //}

            //select
            var selectResult = from s in StudList1
                               select s.fname;

            foreach (var i in selectResult)
                {
                    Console.WriteLine(i);
                }

            //orderby
            var strResult = from str in StudList1.OfType<Student>()
                            orderby str.fname descending
                            select str;

            foreach (var i in strResult)
            {
                Console.WriteLine(i.fname);
            }

            //group by

            var grpby = from gb in StudList1
                        group gb by gb.fname;

            foreach (var i in grpby)
            {
                Console.WriteLine(i.Key);
            }



            //avg/Max

            //IList<string> avg = new List<string>() {"10","20","30","abc", };

            //foreach (var i in StudList1)
            //{
            //    Console.WriteLine(i.fname + "," + i.lname);
            //}

            //foreach (var i in StudList1)
            //{
            //    Console.WriteLine(i.fname+","+i.lname);
            //}

            Console.ReadKey();
        }
    }
}
