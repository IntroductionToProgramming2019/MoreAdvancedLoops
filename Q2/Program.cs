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

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of years: ");
            int number_years = int.Parse(Console.ReadLine());
            int total_rainfall = 0;
            for (int year = 1; year <= 12; year++)
            {
                for (int month = 0; month <= 12; month++)
                {
                    Console.WriteLine("Enter rainfall in inches for month {0} in year {1}:", month, year);
                    int input = int.Parse(Console.ReadLine());
                    total_rainfall = total_rainfall + input; 
                }
            }
            double average = total_rainfall / (number_years * 12);
            Console.WriteLine("Average rainfall ovr the {0} years was {1} inches / month", number_years, average);
        }
    }
}
