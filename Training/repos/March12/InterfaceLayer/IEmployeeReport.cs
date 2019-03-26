using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomModel;

namespace InterfaceLayer
{
    public interface IEmployeeReport
    {
        List<EmployeeModel> GetAllEmp();
        List<EmployeeModel> GetEmp(int x);
        bool SaveEmployee();



    }
}
