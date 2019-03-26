using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{

    class Customer
    {
        protected int custId = 1;
        protected String custName = "sayali";

        public void CustDisplay()
        {
            Console.WriteLine("Customer id is " + custId);
            Console.WriteLine("Customer Name is " + custName);
        }

    }

    class Emp1 : Customer
    {


        protected int empId = 2;
        protected String empName = "Pooja";

        public void EmpDisplay()
        {
            base.CustDisplay();
            Console.WriteLine("emp id is " + empId);
            Console.WriteLine("emp Name is " + empName);
        }

    }

    class Manager : Emp1
    {


        protected int ManagerId = 3;
        protected String ManagerName = "rutika";

        public void ManagerDisplay()
        {
            base.EmpDisplay();
            Console.WriteLine("manager id is  " + ManagerId);
            Console.WriteLine("manager Name is  " + ManagerName);
            Console.ReadLine();
        }

    }
}


