using System;
using System.Collections;


namespace Learning
{
    public static class CProgram
    {
        public static List<List<int>> groupSort(List<int> arr)
        {
            List<List<int>> list = new List<List<int>>();
            var getelemnt = arr.Distinct().ToList();

            for(int i = 0; i < getelemnt.Count; i++)
            {
                List<int> lstAdd = new List<int>();
                int value = getelemnt[i];
                int count = arr.Count(x => x  == value);
                lstAdd.Add(value);
                lstAdd.Add(count);
                list.Add(lstAdd);
            }
            list.OrderBy(x=> x).ToList();

            return list;
        }
    }
    public class Class2
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < 20; i++)
            {
                if(a[i]%2 == 0)
                    yield return (int)(a[i]);
            }
        }
    }

    class sample
    {
        int i;
        double k;
        public sample(int ii,double kk)
        {
            i = ii;
            k = kk;
            double j = (i) + (k);
            Console.WriteLine(j);
        }
        ~sample()
        {
            double j = i - k;
            Console.WriteLine(j);
        }
    }
}
