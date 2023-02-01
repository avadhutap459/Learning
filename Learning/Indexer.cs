using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    /// <summary>
    /// We can create only one Indexer to the particular class
    /// </summary>
    internal class Indexer
    {
        private string[] names = new string[10];

        private int[] Intnames = new int[10];
        public string this[int i]
        {
            get
            {
                return names[i];
            }
            set
            {
                names[i] = value;
            }

        }
       
    }
}
