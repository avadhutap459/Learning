using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning._17052024.EException
{
    public class ClsException
    {
        public void printexceptionwithfinallyblock()
        {
            try
            {

            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
        }
        public void printexceptionwithoutfinallyblock()
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        public void tryandfinallywithoutcatch()
        {
            try
            {

            }
            finally
            {

            }
        }
    }
}
