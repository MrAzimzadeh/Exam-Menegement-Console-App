using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamMenegementSystem
{
    public class Utilities
    {
        public static bool Check(string value)
        {
            try
            {
                Convert.ToInt32(value);
                return true;

            }
            catch (System.Exception e) 
            {

                System.Console.WriteLine(e.Message);
                return false;
            }
        }   

    }
}