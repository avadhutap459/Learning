using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning._17052024
{


    public class ClsBase
    {
        public ClsBase() 
        {
            Console.WriteLine("Base class :: Default Constructor");
        }

    }

    public class ClsDerive : ClsBase
    {
        public ClsDerive(int i) 
        {
            Console.WriteLine("Derive class :: Paramatersie ");
        }

    }



    /// <summary>
    /// Public constructor and Protected constructor both does not exist in one class
    /// Public constructor and private constructor both does not exist in one class
    /// Protected constructor and private constructor both does not exist in one class
    /// </summary>
    public class ClsPublicContainConstructor
    {
        public ClsPublicContainConstructor()
        {
            Console.WriteLine("public class inside public constructor");
        }
        static ClsPublicContainConstructor()
        {
            Console.WriteLine("public class inside static constructor");
        }
        public ClsPublicContainConstructor(string _param)
        {
            Console.WriteLine("public class inside parameterize constructor");
        }
        //protected ClsPublicContainConstructor()
        //{
        //    Console.WriteLine("public class inside protected constructor");
        //}

        //private ClsPublicContainConstructor()
        //{
        //    Console.WriteLine("public class inside private constructor");
        //}

    }

    /// <summary>
    /// If we have created private constructor then not able create object of class
    /// </summary>
    public class ClsPublicContainPrivateConstructor
    {
        private ClsPublicContainPrivateConstructor()
        {
            Console.WriteLine("public class inside private constructor");
        }

        /// <summary>
        /// Below method will not able access because private constructor exists
        /// </summary>
        public void Printnonstaticmethod()
        {
            Console.WriteLine("print none static method");
        }

        /// <summary>
        /// We can able to access below method base on class name 
        /// </summary>
        public static void Printstaticmethod()
        {
            Console.WriteLine("print static method");
        }

    }

    /// <summary>
    /// If we have created protected constructor then not able create object of below class
    /// Below class able to access in derive class
    /// static and protected constructor can create in one class
    /// </summary>
    public class ClsPublicContainStaticNProtectedConstructor
    {
        protected ClsPublicContainStaticNProtectedConstructor()
        {
            Console.WriteLine("public class inside protected constructor");
        }
        static ClsPublicContainStaticNProtectedConstructor()
        {
            Console.WriteLine("public class inside static constructor");
        }
    }

    public class Clsderive_protectedconstructor : ClsPublicContainStaticNProtectedConstructor
    {
        public Clsderive_protectedconstructor()
        {
            Console.WriteLine("public class inside public constructor");
        }
    }

    /// <summary>
    /// We can not create object below class
    /// We can funcationality via through class name 
    /// </summary>
    public class ClsPublicContainStaticNPrivateConstructor
    {
        private ClsPublicContainStaticNPrivateConstructor()
        {
            Console.WriteLine("public class inside private constructor");
        }
        static ClsPublicContainStaticNPrivateConstructor()
        {
            Console.WriteLine("public class inside static constructor");
        }
    }


    public class Clspublicclassinsideprivateclass
    {
        private class Clsprivatemodifier
        {
            static Clsprivatemodifier()
            {
                Console.WriteLine("private class contain static constructor");
            }

            public void printstaticconstructorinsideprivateclass()
            {
                Console.WriteLine("private class contain public method");
            }
        }

        public class Clscallprivateclassinsidepublicclass
        {
            Clsprivatemodifier objprivatemodifier = new Clsprivatemodifier();

            public void printstaticconstructorinsideprivateclass()
            {
                objprivatemodifier.printstaticconstructorinsideprivateclass();
            }
        }
    }

}
