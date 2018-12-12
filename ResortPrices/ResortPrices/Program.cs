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
            
        }
    }
}
