using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ScoresComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            const double MAX = 100, MIN = 0;
            double scores;
            double[] arr = new double[4];

            Write("Enter four quiz scores " + " << ");
            for (int i = 0; i < 4; i++)
            {
                Write("Enter another quiz score " + " << ");
                scores = Convert.ToDouble(ReadLine());

                if (scores >= MIN && scores <= MAX)
                {
                    arr[i] = scores;
                    WriteLine("The entered test scores {0} ", i);
                }
                else
                {
                    Write("ERROR, Please Try Again... ");
                    --i;
                }
            }
            if (arr[0] <= arr[1] && arr[1] <= arr[2] && arr[2] <= arr[3])
            {
                WriteLine("Congratulations! ");
                for (int i = 0; i < 4; ++i)
                {
                    WriteLine(arr[i]);
                }
            }
            else if (arr[0] >= arr[1] && arr[1] >= arr[2] && arr[2] >= arr[3])
            {
                WriteLine("This is going to be a yikes from me dawg :/. ");
                for (int i = 0; i < 4; ++i)
                {
                    WriteLine(arr[i]);
                }
                WriteLine("Got to get out of this mud and IMPROVE! ");
                for (int i = 3; i >= 0; --i)
                {
                    WriteLine(arr[i]);
                }
            }
            else
            {
                WriteLine("Holy Moly, It goes from 0 to 100, then back to 0, then back to 100... you get the point! ");
            }




        }
    }
}
