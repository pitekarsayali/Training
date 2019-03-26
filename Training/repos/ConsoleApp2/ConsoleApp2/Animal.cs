using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Animal
    {
        public abstract void IsDead();
        public abstract void Eating();

    }
    class Cat : Animal
    {
        public override void IsDead()
        {
            Console.WriteLine("Not Dead");
            
        }
        public override void Eating()
        {
            Console.WriteLine("cat is eating");

        }
    }
    class Dog : Animal
    {
        
        public override void Eating()
        {
            Console.WriteLine("dog is eating");
           

        }
        public override void IsDead()
        {
            Console.WriteLine("Dead");
            Console.ReadLine();

        }
    }
}
