using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessReport;
using CustomModel;
using DBRepository;
using ActualDB;
namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n enter choice");
            int a =Convert.ToInt32(Console.ReadLine());
            int ch = 0;
            if (a == 1)
            {
                ch = 1;
            }
            if (a == 2)
            {
                ch = 2;
            }
            
            EmployeeBLReport eReport = new EmployeeBLReport(ch);

            var item1 = eReport.GetAllEmp();


            foreach (EmployeeModel i in item1)
            {
                System.Console.WriteLine(i.Id);
                System.Console.WriteLine(i.Name);
                System.Console.WriteLine(i.Address);
            }
            System.Console.ReadLine();


            var item = eReport.GetAllEmp();


            foreach (EmployeeModel i in item)
            {
                System.Console.WriteLine(i.Id);
                System.Console.WriteLine(i.Name);
                System.Console.WriteLine(i.Address);
            }
            System.Console.ReadLine();
            // eReport.GetAllEmp();
            //eReport.GetEmp(2);
            //eReport.SaveEmployee();




        }
    }
}
