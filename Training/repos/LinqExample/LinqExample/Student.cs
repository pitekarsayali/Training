using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
   public class Student
    {
        public string fname { get; set; }
        public string lname { get; set; }
    }


    public class Studetails
    {
        public IList<Student> Getdata()
        {
            IList<Student> StudList = new List<Student>();
            StudList.Add(new Student() { fname = "sayali", lname = "pitekar" });
            StudList.Add(new Student() { fname = "mayuri", lname = "shewale" });
            return StudList;
        }

    }

    
}
