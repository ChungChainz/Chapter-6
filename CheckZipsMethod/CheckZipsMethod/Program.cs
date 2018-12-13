using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckZipsMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            string zip;

            string displayZips;

            Write("Enter the zip code you want to deliver to >>> ");
            zip = (ReadLine());
            displayZips(zip);
        }
        private static string displayZips = (string zip); 
         {   bool delivery = true;
        int[] zipcodes = { 52800, 52801, 52802, 52803, 52804, 52805, 52806, 52807, 52808, 52809 };
        int i = 0;
            while (i< 10)
            {
                if (zip == zipcodes[i])
                {
                    delivery = false;
                    WriteLine("This is a valid delivery zip code.");
    
                else
                {

                }
                ++i;
            

                if (delivery == false)
                {

                }
                else if (delivery == true)
                   {
                    WriteLine("Can't deliver here, sorry");

        }   
    }
}              
        
   

