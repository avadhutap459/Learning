using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class MissedLearing
    {
        public MissedLearing()
        {
            Console.WriteLine("Public constructor");
        }
        static MissedLearing()
        {
            Console.WriteLine("Static constructor");
        }
        public string name { get; set; }
        public MissedLearing(string name)
        {
            this.name = name;
            Console.WriteLine(name);
        }
        public MissedLearing(MissedLearing objMissedL)
        {
            Console.WriteLine(objMissedL.name + " " + "Copy constructor");
        }

        //private MissedLearing()
        //{
        //    Console.WriteLine("Private constructor");
        //}
    }



    public class ParentConstructor
    {
        static ParentConstructor()
        {
            Console.WriteLine("Parent class :- Public constructor");
        }
        protected ParentConstructor()
        {
            Console.WriteLine("Parent class :- Protected constructor");
        }
    }

    public class ChildConstructor : ParentConstructor
    {
        public ChildConstructor() : base()
        {
            Console.WriteLine("Child class :- public constructor");
        }
    }


   public class ClsPrivateConstructor
    {
        private ClsPrivateConstructor()
        {
            Console.WriteLine("Private constructor");
        }
    }


    public class clsPropety
    {
        public string name { get; set; } = "Public Property";
        public static string StaticPro { get; set; } = "Static Property";
        internal string InternalPro { get; set; } = "Internal Property";
        private string PrivatePro { get; set; } = "Private Property";
        public string PublicPro
        {
            get { return PrivatePro;  }
            set { PrivatePro = value; }
        }
    }

}
