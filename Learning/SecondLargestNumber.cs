using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class SecondLargestNumber
    {
        public void RetrunSecondLargestNumber()
        {
            int[] myArray = new int[] { 0, 1, 2, 3, 13, 8, 5 };

            List<int> list = myArray.ToList();

            var GetResult = list.OrderByDescending(x=>x).Skip(1).Take(1);

            string inputstr = "DOTNETWORLD";

            var GetOccurnaceChar = inputstr.ToCharArray().GroupBy(x => x).ToList();

            foreach(var v in GetOccurnaceChar)
            {
                Console.WriteLine(v.Key );
            }

            int num1 = 0, temp = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] >= num1)
                {
                    num1 = myArray[i];
                }
                else if ((myArray[i] < num1) && (myArray[i] > temp))
                {
                    temp = myArray[i];
                }
            }
            Console.WriteLine("The Largest Number is: " + num1);
            Console.WriteLine("The Second Highest Number is: " + temp);

        }
    }
}
