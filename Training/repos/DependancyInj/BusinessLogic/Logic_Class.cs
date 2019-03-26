using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBRepository;
using Entity;

namespace BusinessLogic
{
    public class Logic_Class
    {
        Employee e = new Employee();

        public void GetAllMethods()
        {
            e.GetAllEmp();
        }
    }
}
