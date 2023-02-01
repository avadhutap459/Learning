using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class PrivateConstructor
    {
        public String Surname { get; set; }

        public PrivateConstructor()
        {
            Console.WriteLine("private Constructor");
        }

        

        static PrivateConstructor()
        {
            Console.WriteLine("Static Constructor");
        }
        public PrivateConstructor(string surname)
        {
            Surname = surname;
        }

        public static void Print()
        {
            System.Console.WriteLine("Static constructor contain static method");
        }

    }
}
