using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class InheritanceClass
    {
        public InheritanceClass() 
        {
            Console.WriteLine("Super class Constructor");
        }
        public void display()
        {
            Console.WriteLine("Super Class Method");
        }
    }
    class BaseClass : InheritanceClass
    {
        public BaseClass()
        {
            Console.WriteLine("Child  Class Constructor");
        }
        public void display()
        {
            Console.WriteLine("Child Class Method");
        }
    }
}
