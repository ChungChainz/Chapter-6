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
            double[] scores = new double[4];
            const double MAX = 100, MIN = 0;
           
            Write("Enter four quiz scores " + " << ");
            for(int i = 0; i < 4; i++)
            {
                Write("Enter another quiz score " + " << ");
                scores[i] = Convert.ToDouble(ReadLine());

                if (scores[i] >= MIN && scores[i] <= MAX)
                {
                    if ()
                }
                else
                {
                    Write("ERROR");
                }
            }
            



        }
    }
}
