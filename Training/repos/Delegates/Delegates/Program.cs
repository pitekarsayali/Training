using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> empl = new List<Employee>();
            empl.Add(new Employee() { ID = 101, Name = "sayali", salary = 20000, Experiance = 3, grade = "E1" });
            empl.Add(new Employee() { ID = 102, Name = "pooja", salary = 30000, Experiance = 5, grade = "E1" });
            empl.Add(new Employee() { ID = 103, Name = "mayuri", salary = 50000, Experiance = 8, grade = "E2" });
            empl.Add(new Employee() { ID = 104, Name = "kimaya", salary = 10000, Experiance = 2, grade = "E2" });
            empl.Add(new Employee() { ID = 104, Name = "Shweta", salary = 90000, Experiance = 9, grade = "E2" });
            //Employee.PromoteEmp(empl);
            isPromote pro = new isPromote(promote);
            Employee.PromoteEmp(empl, pro);
        }
        public static bool promote(Employee emp)
        {
            if (emp.Experiance >= 5)
            {
                return true;
            }
            if (emp.Experiance >= 5 && emp.grade == "E2")
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }

    delegate bool isPromote(Employee emp);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
        public float Experiance { get; set; }
        public string grade { get; set; }


        public static void PromoteEmp(List<Employee> EmployeeList, isPromote IsEligible)
        {
            foreach (Employee emp in EmployeeList)
            {
                if (IsEligible(emp))//logic condition  
                {
                    Console.WriteLine(emp.Name + " Promoted");
                }
            }
            Console.ReadKey();
        }

    }
}
