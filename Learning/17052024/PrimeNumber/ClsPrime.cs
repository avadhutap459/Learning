using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning._17052024.PrimeNumber
{
    public  class ClsPrime
    {
        public bool Ischeckprimenumberornot(int num)
        {
            int i, m = 0, flag = 0;
            Console.Write("Enter the Number to check Prime: ");

            m = num / 2;
            for (i = 2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    return false;
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                return true;

            return false;

        }
    }
}
