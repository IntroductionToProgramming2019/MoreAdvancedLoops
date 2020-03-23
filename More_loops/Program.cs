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

namespace More_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int speed = 0;
            int hours = 0;
            Console.WriteLine("Enter the speed of the vehicle: ");
            speed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how long the vehicle travelled: ");
            hours = int.Parse(Console.ReadLine());
            while (speed != -999 && hours != -999)
            {
          
                if (speed < 0)
                {
                    Console.WriteLine("Error. Try again. ");
                }
                else if (hours < 1)
                {
                    Console.WriteLine("Error. Try again. ");
                }
                else
                {
                    Console.WriteLine("hour\tDistanceTravelled");
                    for (int i = 1; i <= hours; i++)
                    {
                        int distance = i * speed;
                        Console.WriteLine("{0}\t{1}", i, distance);
                    }
                }
                Console.WriteLine("Enter the speed of the vehicle: ");
                speed = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter how long the vehicle travelled: ");
                hours = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Programme ending ... ");
        }
    }
}
