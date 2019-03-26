using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLayer;
using CustomModel;

namespace ActualDB
{
    public class Empl: IEmployeeReport
    {
        WebApiDBEntities db = new WebApiDBEntities();


        public List<EmployeeModel> GetAllEmp()
        {


            List<EmployeeModel> list1 = new List<EmployeeModel>();

            var k = db.Emps.ToList();


            foreach (var item in k)
            {
                EmployeeModel m = new EmployeeModel();
                m.Id = item.Id;
                m.Name = item.Name;
                m.Address = item.Address;

                list1.Add(m);

            }




            return list1;

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
