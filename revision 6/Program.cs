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

namespace revision_6
{
    class Program
    {
        static void Main(string[] args)
        {
           int total = 0;
            int largest = 0;
            int smallest = 0;
            int Smallest =0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter a value: ");
                int input = int.Parse(Console.ReadLine());
                total = total + input;
                if ( smallest < input)
                {
                    Smallest = smallest;
                }
                else
                {
                    smallest = input;
                }
            }
            int average = total / 5;
            Console.WriteLine(average);
            Console.WriteLine(Smallest);
        }
    }
}
