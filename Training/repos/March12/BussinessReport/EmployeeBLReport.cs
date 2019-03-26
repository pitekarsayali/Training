using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using March12;
using CustomModel;
using ActualDB;
using InterfaceLayer;

namespace BussinessReport
{
    public class EmployeeBLReport
    {
        //EmployeeReport bl = new EmployeeReport();

        //Empl bl = new Empl();
        IEmployeeReport i1;

        public EmployeeBLReport(int x)

        {
            if (x==1)
            {
                i1 = new EmployeeReport();
            }
            if (x == 2)
            {
                i1 = new Empl();
            }

        }




        public List<EmployeeModel> GetAllEmp()
        {

            
           

            return i1.GetAllEmp();

        }

        public List<EmployeeModel> GetEmp(int y)
        {
          return i1.GetEmp(2);
            

        }

        public bool SaveEmployee()
        {
            i1.SaveEmployee();

            return true;

        }

    }
}
