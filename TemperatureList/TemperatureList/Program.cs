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
            int[] temps = new int[7];
            int average;
            int distance;
            int i;
            WriteLine("Input the temperatures for the next 7 days ");
            for ( i = 0; i < 7; i++)
            {
                int j = i + 1;
                WriteLine("Enter temperatures " + j + " >> ");
                temps[i] = Convert.ToInt32(ReadLine());
            }
            average = (temps[0] + temps[1] + temps[2] + temps[3] + temps[4] + temps[5] + temps[6]) / 10;
            for( i = 0; i < 7; i++)
            {
                int j = i + 1;
                WriteLine("Temperature " + j + " is " + temps[i] + " and is " + Math.Abs(temps[i] - average) + " away from the average");
            }
        }
    }
}
