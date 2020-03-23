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

namespace revision_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter a value: ");
                int number = int.Parse(Console.ReadLine());
                if (number % 2 != 0)
                {
                    total = total + 1;

                }
            }
            Console.WriteLine(total);
        }
    }
}
