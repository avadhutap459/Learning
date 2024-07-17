using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning._17052024.AccessModifier
{
    public class ClsAccessModifier
    {
        private class Clsprivateaccessmodifier
        {
            
            public void printprivatemodifier()
            {
                Console.WriteLine("access modifier >> private");
            }
        }

        protected class Clsprotectedaccessmodifier
        {

        }
        public class Clscallprivateclassinsidepublic
        {
            Clsprivateaccessmodifier objprivateaccessmodifier = new Clsprivateaccessmodifier();

            public void printprivatemodifier()
            {
                objprivateaccessmodifier.printprivatemodifier();
            }
        }
    }

    public class Clspublicaccessmodifier
    {
        public void printpublicmodifier()
        {
            Console.WriteLine("access modifier >> public");
        }
    }

    
    
}
