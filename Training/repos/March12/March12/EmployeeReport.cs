using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomModel;
using InterfaceLayer;


namespace March12
{
    //interface IEmployeeReport
    //{
    //    List<EmployeeModel> GetAllEmp();
    //    List<EmployeeModel> GetEmp(int x);
    //    bool SaveEmployee();



    //}



    public class EmployeeReport: IEmployeeReport
    {


       public  List<EmployeeModel> GetAllEmp()
        {

            List<EmployeeModel> EmpList = new List<EmployeeModel>();
            EmpList.Add(new EmployeeModel() {Id=1, Name = "sayali", Address = "pune" });
            EmpList.Add(new EmployeeModel() { Id=2,Name = "pooja", Address = "Nashik" });
            EmpList.Add(new EmployeeModel() { Id = 3, Name = "Haritha", Address = "nagar" });

            return EmpList;

        }









        public List<EmployeeModel> GetEmp(int y)
        {




            return new List<EmployeeModel>();

        }

        public bool SaveEmployee()
        {




            return true;

        }

        
    }
}
