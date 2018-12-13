using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ResortPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int nights;
            int[] prices = { 200, 200, 180, 180, 160, 160, 160, 145 };
            int total = 0;
            int i = 0;
           
            Write("How many nights have you stayed at 'The Carefree Resort'?");
            nights = Convert.ToInt32(ReadLine());

            if(nights < 8)
            {
                total += prices[nights] * nights;
            }
            else if (nights >= 8)
            {
                total += prices[8] * nights;
            }
             WriteLine();
            WriteLine("These are the nightly rates");
            WriteLine("________________________________");
            for (i = 0; i < 9; ++i)
            {
                if (i < 8)
                {
                    WriteLine("The price for " + i + " night(s) is $" + prices[i]);
                }
                else
                {
                    WriteLine("The price for 8 nights or more is $" + prices[7]);
                }

            }

           
            WriteLine("\n _________________________________");
            WriteLine("Your total for " + nights + " nights stayed is " + total.ToString("C"));
        }
    }
}
