using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning._17052024.Dependancy
{
    public interface IDependancy
    {
        void print(string param);
    }
    public class ClsDependancy : IDependancy
    {
        public void print(string param)
        {
            Console.WriteLine(param + " dependancy injection");
        }
    }

    public class Clsconstructordependancy
    {
        private IDependancy _dependancy { get; set; }
        public Clsconstructordependancy(IDependancy dependancy)
        {
            _dependancy = dependancy;
        }

        public void print()
        {
            _dependancy.print("Constructor base");
        }
    }

    public class Clspropertydependancy
    {
        private IDependancy _dependancy { get; set; }

        public IDependancy dependancy
        {
            get
            {
                    return _dependancy;
            }
            set
            {
                _dependancy = value;

            }

        }

        public void print()
        {
            _dependancy.print("Property base");
        }
    }

}
