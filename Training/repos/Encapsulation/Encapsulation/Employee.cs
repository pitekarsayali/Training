using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Employee
    {
        public int empId;
        public String empName;
        public int salary;

        public void  getInfo()
        {
            Console.Write("Please enter Emp id: ");
            empId=Convert.ToInt32(Console.ReadLine());

             Console.Write("Please enter EmpName: ");
            empName = Console.ReadLine();


            Console.Write("Please enter Emp id: ");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public void empDisplay()
        {
            Console.Write(" EmpId: "+ empId);
            Console.Write(" EmpName: " + empName);
            Console.Write(" Sakary: " + salary);

        }

    }
}
