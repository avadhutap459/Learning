using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class StaticVPrivateClass
    {
        // public int i;
        public StaticVPrivateClass()
        {
            Console.WriteLine("Public Constructor  Base Class");
        }
        static StaticVPrivateClass()
        {
            Console.WriteLine("Static Constructor Base Class");
        }
       
    }

    public class NormalClass : StaticVPrivateClass
    {
        public NormalClass()
        {
            Console.WriteLine("Public Constructor");
        }
    }

    public static class _StaticCls_N_Interface
    {
        interface IStatic
        {
            void Print();
        }

        public class _NonStaticCls : IStatic
        {
            public void Print()
            {
                Console.WriteLine("Static class with interface");
            }
        }
    }
}
