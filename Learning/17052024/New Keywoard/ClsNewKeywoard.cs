using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning._17052024.New_Keywoard
{
    public class ClsNewKeywoard
    {
        public void Print()
        {
            Console.WriteLine("Display new keyward map with method");
        }
    }

    public class ClsDeriveNewKeyward : ClsNewKeywoard
    {
        public new void Print()
        {
            Console.WriteLine("Display derive class method ");
        }
    }
}
