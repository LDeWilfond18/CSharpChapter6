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
            int days;
            int[] nightPrices = { 0, 200, 200, 180, 180, 160, 160, 160, 145 };
            Write("Welcome to the Carefree Resort. How many nights?");
            days = Convert.ToInt32(ReadLine());
            if(days >= 8)
            {
                WriteLine("The cost will be " + nightPrices[days]);
            }
            else if (days > 8)
            {
                WriteLine("Error");
            }

        }
    }
}
