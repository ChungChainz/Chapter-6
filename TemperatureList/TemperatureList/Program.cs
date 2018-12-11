using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 
namespace TemperatureList
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temp = new double[7];
            double avg;
            double number = 0;

            Write("Enter 7 days worth of high temperatures here" + " << " );
            for(int i = 0; i < 7; i++)
            {
                Write("Add another temp - " + " << ");
                temp[i] = Convert.ToDouble(ReadLine());
            }
            double sum = temp.Sum();
            avg = temp.Sum() / 7;

            WriteLine("The average temperature is {0} degrees.", avg);
             for (int i = 0; i < 7; i++)
            {
                ++number;
                WriteLine("The temperature was " + number + " is " + Math.Abs(temp[i] - avg) + " degrees from the average.");
                
            }
        }
    }
}
