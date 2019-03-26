using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace DependancyInj
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic_Class l = new Logic_Class();
            l.GetAllMethods();

        }
    }
}
