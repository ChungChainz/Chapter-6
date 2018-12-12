using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zipcodes = { 52800, 52801, 52802, 52803, 52804, 52805, 52806, 52807, 52808, 52809 };
            int zip;
            bool delivery = true;
            int i = 0;
            Write("Enter the zip code you want to deliver to >>> ");
            zip = Convert.ToInt32(ReadLine());

            while (i < 10)
            {
                if (zip == zipcodes[i])
                {
                    delivery = false;
                    WriteLine("This is a valid delivery zip code.");
                }
                else
                {

                }
                ++i;
            }

                if (delivery == false)
                {

                }
                else if (delivery == true)
                {
                    WriteLine("Can't deliver here, sorry");
                }
            }
        }
    }
}
