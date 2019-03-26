using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayCode
{
    class Program
    {

        Employee empObject = new Employee();
        public void SortArrayList()
        {




        }
        private void DisplaySortedArrayLis()
        {


        }
        static void Main(string[] args)
        {
            Employee empObject = new Employee();

            empObject.FillData();
            for (int i = 0; i < 15; i++)
            {

                if ((i + 1 < 15) && (empObject.empArray[i].Salary < empObject.empArray[i + 1].Salary))
                {

                    var t = empObject.empArray[i].Salary;
                    empObject.empArray[i].Salary = empObject.empArray[i + 1].Salary;
                    empObject.empArray[i + 1].Salary = t;
                }

            }

            for (int k = 0; k < 15; k++)
            {

                Console.WriteLine(empObject.empArray[k].Id);
                Console.WriteLine(empObject.empArray[k].Name);
                Console.WriteLine(empObject.empArray[k].Salary);
                Console.WriteLine();
            }
            Console.WriteLine("Enetr the Id to return recored");
            int Id = Convert.ToInt32(Console.ReadLine());
            if (Id < 15)
            {
                Employee temp = empObject.empArray.FirstOrDefault(e => e.Id == Id);
                Console.WriteLine(temp.Id);
                Console.WriteLine(temp.Name);
                Console.WriteLine(temp.Salary);
            }
            for (int z = 0; z < empObject.ArrayList.Count; z++)
            {
                if ((z + 1 < 15) && (empObject.empArray[z].Salary < empObject.empArray[z + 1].Salary))
                {

                    var t = ((Employee)empObject.ArrayList[z]).Salary;

                    ((Employee)empObject.ArrayList[z]).Salary = ((Employee)empObject.ArrayList[z + 1]).Salary;
                    ((Employee)empObject.ArrayList[z + 1]).Salary = t;
                }

            }
            Console.WriteLine("Displaying Sorted Array List Items Based On Salary");
            for (int z = 0; z < 10; z++)
            {
                Console.WriteLine(((Employee)empObject.ArrayList[z]).Id);
                Console.WriteLine(((Employee)empObject.ArrayList[z]).Name);
                Console.WriteLine(((Employee)empObject.ArrayList[z]).Salary);
                Console.WriteLine();

            }

        }
    }
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public ArrayList ArrayList = new ArrayList();
        public Employee[] empArray = new Employee[20];

        public void FillData()
        {
            empArray[0] = new Employee() { Id = 0, Name = "sayali", Salary = 20000000 };
            ArrayList.Add(new Employee() { Id = 0, Name = "pooja", Salary = 20000000 });
            empArray[1] = new Employee() { Id = 1, Name = "dipa", Salary = 20000000 };
            ArrayList.Add(new Employee() { Id = 1, Name = "Soni", Salary = 20000000 });
            empArray[2] = new Employee() { Id = 2, Name = "saniya", Salary = 2878 };
            ArrayList.Add(new Employee() { Id = 2, Name = "Priya", Salary = 2878 });
            empArray[3] = new Employee() { Id = 3, Name = "diya", Salary = 4557 };
            ArrayList.Add(new Employee() { Id = 3, Name = "rutu", Salary = 4557 });
            empArray[4] = new Employee() { Id = 4, Name = "mona", Salary = 87799989 };
            ArrayList.Add(new Employee() { Id = 4, Name = "raju", Salary = 87799989 });
            empArray[5] = new Employee() { Id = 5, Name = "kimaya", Salary = 4545 };
            ArrayList.Add(new Employee() { Id = 5, Name = "haritha", Salary = 4545 });
            empArray[6] = new Employee() { Id = 6, Name = "soniya", Salary = 897876 };
            ArrayList.Add(new Employee() { Id = 6, Name = "Pranali", Salary = 897876 });
            empArray[7] = new Employee() { Id = 7, Name = "dipika", Salary = 86675 };
            ArrayList.Add(new Employee() { Id = 7, Name = "prachi", Salary = 86675 });
            empArray[8] = new Employee() { Id = 8, Name = "sakshi", Salary = 89886 };
            ArrayList.Add(new Employee() { Id = 8, Name = "mahima", Salary = 89886 });
            empArray[9] = new Employee() { Id = 9, Name = "Aliya", Salary = 243 };
            ArrayList.Add(new Employee() { Id = 9, Name = "Arya", Salary = 243 });
            empArray[10] = new Employee() { Id = 10, Name = "Kumari", Salary = 645656 };
            ArrayList.Add(new Employee() { Id = 9, Name = "mahi", Salary = 243 });
            empArray[11] = new Employee() { Id = 11, Name = "pratima", Salary = 88667 };
            ArrayList.Add(new Employee() { Id = 11, Name = "karina", Salary = 88667 });
            empArray[12] = new Employee() { Id = 12, Name = "aish", Salary = 654545 };
            ArrayList.Add(new Employee() { Id = 12, Name = "shradha", Salary = 654545 });
            empArray[13] = new Employee() { Id = 13, Name = "samantha", Salary = 55545 };
            ArrayList.Add(new Employee() { Id = 13, Name = "anushka", Salary = 55545 });
            empArray[14] = new Employee() { Id = 14, Name = "dipali", Salary = 86756 };
            ArrayList.Add(new Employee() { Id = 14, Name = "rutuja", Salary = 86756 });


        }
    }
}
