using DBRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DBRepository
{
    interface IEmp
    {
        List<Emp>GetAllEmp();
        List<Emp>GetEmp(Emp e);
        void SaveEmp();
    }
}

public class Employee: IEmp
{
    Model1Container db = new Model1Container();
    //Employee e = new Employee();

    public List<Emp> GetAllEmp()
    {

      var k =   db.Emps.ToList();




        foreach (Emp p in k)
        {
            System.Console.WriteLine(p.Id);
            System.Console.WriteLine(p.Name);
            System.Console.WriteLine(p.Address);
        }

        return new List<Emp>();

    }

    public List<Emp> GetEmp(Emp e)
    {
        List<Emp> listOfEmp1 = new List<Emp>();

        var m = db.Emps.ToList() ;

        

        System.Console.WriteLine(m.);

        return listOfEmp1;


    }

    public void SaveEmp()
    {

    }

   

}
