using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Manager m = new Manager();
        //    m.ManagerDisplay();

            Employee[] arr = new Employee[3];
            for (int k = 0; k < 2; k++)
            {
                arr[k] = new Employee();
            }

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Please enter Emp id: ");
                int id = Convert.ToInt32(Console.ReadLine());

                arr[i].EmpId = id;

                Console.Write("Please enter EmpName: ");
                String str = Console.ReadLine();
                arr[i].EmpName = str;


                Console.Write("Please enter EmpSalary: ");
                int Salary = Convert.ToInt32(Console.ReadLine());
                arr[i].Salary = Salary;

            }


            Console.WriteLine("Enter The Record No");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(arr[index].EmpId);
            Console.WriteLine(arr[index].EmpName);
            Console.WriteLine(arr[index].Salary);
            Console.ReadLine();



            //Emp[] arr = new Emp[5];

            //for (int k = 0; k < 5; k++)
            //{
            //    arr[k] = new Emp();
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Please enter Emp id: ");
            //    int id = Convert.ToInt32(Console.ReadLine());

            //    arr[i].EmpId = id;

            //    Console.Write("Please enter EmpName: ");
            //    String str = Console.ReadLine();
            //    arr[i].EmpName = str;


            //    Console.Write("Please enter EmpSalary: ");
            //    int Salary = Convert.ToInt32(Console.ReadLine());
            //    arr[i].Salary = Salary;

            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Emp id: " + arr[i].EmpId);
            //    Console.Write("EmpName: " + arr[i].EmpName);

            //    Console.Write("isEmpSalary: " + arr[i].Salary);
            //    Console.WriteLine();


            //}
            //Console.ReadLine();


        }
    }

        class Employee
        {
            public int empId;
        public String empName;
        public int salary;

            public int EmpId { get => empId; set => empId = value; }
            public string EmpName { get => empName; set => empName = value; }
            public int Salary { get => salary; set => salary = value; }

            

        }

    }