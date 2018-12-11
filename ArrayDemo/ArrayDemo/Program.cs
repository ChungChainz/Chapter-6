using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] arr = new int[8];
            int i;
            int picknum;

            Write("Input 8 integers in an array");
            for (i = 0; i < 8; i++)
            {
                Write("Enter number - " + "<<" );
                arr[i] = Convert.ToInt32(ReadLine());
            }
            
            {
                Write("Enter {1} To view list in order, {2} To see the reverse, or {3} Choose a specific position");
                picknum = Convert.ToInt32(ReadLine());
                if (picknum == 1)
                {
                    for (i = 0; i < 8; ++i)
                    {
                        WriteLine(arr[i]);
                    }

                }
                else if (picknum == 2)
                {
                    for (i = 7; i > 0; --i)
                    {
                        WriteLine(arr[i]);
                    }
                }
                else if (picknum == 3)
                {
                    WriteLine("Pick a number index from 0-7");
                    picknum = Convert.ToInt32(ReadLine());
                    WriteLine(arr[picknum]);
                }
                else
                {
                    WriteLine("ERROR 404");
                }
            }
        }
    }
}
