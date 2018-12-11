using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Saving_into_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            int arrayChoice;
            int[] arr = new int[10];
            int i;
            Write("\n\nRead and print elements of an array:\n");
            Write("-----------------------------------------\n");
            Write("Input 10 elements in the array");
            for (i = 0; i< 8; i++)
            {
                Write("Enter number - " + i + " << ");
                arr[i] = Convert.ToInt32(ReadLine());
            }
            WriteLine("Choose display");
            choice = Convert.ToInt32(ReadLine());
            if (choice == 1)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    WriteLine("Numbers entered were " + arr[j]);
                }
            }
            else if (choice == 2)
            {
                for (int j = 7; j >= 0; j--)
                {
                    WriteLine("Numbers entered backwards were " + arr[j]);
                }
            }
            else if (choice == 3)
            {
                WriteLine("Choose a position 0-7");
                arrayChoice = Convert.ToInt32(ReadLine());
                WriteLine("Selected number is " + arr[arrayChoice]);
            }
            ReadLine();
        }
    }
}
