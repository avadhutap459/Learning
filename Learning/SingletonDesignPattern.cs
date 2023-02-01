using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class SingletonDesignPattern
    {
        public SingletonDesignPattern()
        {

        }

        private static SingletonDesignPattern Instance = null;

        public static SingletonDesignPattern _Instance
        {
            get
            {
                if(Instance == null)
                    Instance = new SingletonDesignPattern();

                return Instance;
            }
            
        }

    }

    public class InheritSingleToneClass : SingletonDesignPattern
    {

    }

    public sealed class Singleton1
    {
        private Singleton1() { }
        private static Singleton1 instance = null;
        public static Singleton1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton1();
                }
                return instance;
            }
        }
    }
}
