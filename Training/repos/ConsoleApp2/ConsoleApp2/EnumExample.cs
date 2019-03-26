using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class EnumExample
    {
        enum WeekDays
        {
            Monday=10 ,
            Tuesday=4,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public void Display()
        {
            Console.WriteLine((int)WeekDays.Monday);
            Console.WriteLine(WeekDays.Tuesday);
            Console.ReadLine();
        }
        
        
    }
}
