using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //////IShape r = new Rect();
            //////r.Draw();
            //////r.Area();

            //////Cat c = new Cat();
            //////c.Eating();
            //////c.IsDead();
            //////Dog d = new Dog();
            //////d.Eating();
            //////d.IsDead();
            ////Car.Color();
            ///
            //Emp e = new Emp();
            //e.Display(12,"sayali",4.5f,5.55,2);
            //EnumExample e1 = new EnumExample();
            //e1.Display();

          
            // DatatypeConversion d = new DatatypeConversion();
            //// d.Display();
            // d.dis();
            Cons c = new Cons(10);
            //Cons c1 = new Cons();

        }
    }
    interface IShape
    {
        void Draw();
        void Area();
    }
    class Rect : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rctangle Drawing..............");
        }
        public void Area()
        {
            int a = 5;
            int b = 2;
            int area = a * b;
            Console.WriteLine("Area Of Rectangle is  " + area);
            Console.ReadLine();
        }
    }
  
}
