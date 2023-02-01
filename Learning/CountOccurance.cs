using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class CountOccurance
    {
        public  Dictionary<string, int> CountOccurance_(string Letter)
        {
            int i = 0, Count = 0;
            Dictionary<string, int> Occurance = new Dictionary<string, int>();
            while (Letter.Length > 0)
            {
                string temp = Letter[i].ToString();

                for (int j = 0; j < Letter.Length; j++)
                {
                    if (Letter[j].ToString() == temp)
                        Count++;

                }
                Occurance.Add(temp, Count);
                Count = 0;
                Letter = Letter.Replace(temp, string.Empty);
            }
           

            return Occurance;
        }
    }

    public class RemoveDuplicateOccurance
    {
        public string _LamboardRemoveDuplicateOccurance(string Letter)
        {
            return new string(Letter.ToCharArray().Distinct().ToArray());
        }

        public string _RemoveDuplicateOccurance(string Letter)
        {
            int i = 0 ,Count = 0; ;
            string Output= string.Empty;

            while (Letter.Length > 0)
            {
                string _char=Letter[i].ToString();

                for(int j = 0; j < Letter.Length; j++)
                {
                    if (Letter[j].ToString() == _char)
                        Count++;
                }

                if(Count >= 1)
                    Output += _char;

                Letter = Letter.Replace(_char, string.Empty);

            }


            return Output;
        }
    }
}
