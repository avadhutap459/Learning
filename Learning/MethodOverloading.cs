using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class MethodOverloading
    {

        public void Add(int i)
        {
            Console.WriteLine(i);
        }
        public void Add(out int i)
        {
            i = 1;
            Console.WriteLine(i);
        }
    }
}
