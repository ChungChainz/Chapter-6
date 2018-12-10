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
            int exit = 999;
            int[] arr = new int[8];
            int i;
            string pick;
            int picknum;

            Write("Input 8 integers in an array");
            for (i = 0; i < 8; i++)
            {
                Write("Enter number - " + "<<" );
                arr[i] = Convert.ToInt32(ReadLine());
            }
            Write("Enter {1} To view list in order, {2} To see the reverse, or {3} Choose a specific position");
            pick = ReadLine();
            picknum = Convert.ToInt32(pick);
            if(picknum == 1)
            {
                Array.Sort(arr);
            }
            else if (picknum == 2)
            {
                Array.Sort(arr); Array.Reverse(arr);
            }
            else
            {
                WriteLine("Pick a number index #");
                pick = ReadLine();
                picknum = Convert.ToInt32(pick);
            }
                
        }
    }
}
