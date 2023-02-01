using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class SwapNumber
    {
        public void SwapTwoNumberWithoutUseTemp()
        {
            int a = 10,b=20;

            a = a + b;
            b = a - b;
            a = a - b;

        }

        public void SwapTwoNumberUsingTemp()
        {
            int a = 10, b = 20,temp;

            temp = a;
            a = b;
            b = temp;

        }
    }
}
