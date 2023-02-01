using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    //abstract class A
    //{
    //    protected A()
    //    { 
    //        Console.WriteLine("Abstract class constructor"); 
    //    }
    //    public A(string Name)
    //    {
    //        Console.WriteLine(Name);
    //    }
    //}
    ////Derived class
    //class B : A
    //{
    //    public B(string Name) : base(Name) 
    //    { 
    //        Console.WriteLine("Derived class constructor"); 
    //    }
    //}
     class A
    {
       
        public A(int i)
        {
            Console.WriteLine("Paramertize constructor");
        }
    }
    //Derived class
    //class B : A
    //{
    //    public B()
    //    {
    //        Console.WriteLine("Normal Constructor B");
    //    }
    //    public B(int i): base(i)
    //    {
    //        Console.WriteLine("Deafult constructor");
    //    }
    //}
    internal class AbstractClass
    {
    }
}
