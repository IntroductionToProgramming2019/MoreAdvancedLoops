/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : More Advanced Loops
 * 
 * ############################# */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision_3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int num1 = 41;
                int num2 = 60;
                for (num1 = num1; num1 < num2; num1++)
                {
                    if (num1 == 46)
                    {
                        continue;
                    }
                    if (num1 == 48)
                    {
                        continue;
                    }
                    Console.WriteLine(num1);
                }
            }
        }
    }
}
