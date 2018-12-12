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
            int userZip;
            int i = 0;
            int[] zips = { 11111, 22222, 33333, 44444, 55555, 66666, 77777, 88888, 99999, 52804 };

            Write("Enter the zip code of the package");
            userZip = Convert.ToInt32(ReadLine());

            while(userZip != zips[i])
            {
                i++;
                if (userZip == zips[i])
                {
                    WriteLine("Package is in the right trailer");
                }
                else
                    WriteLine("Misflow, do not load");
            }
        }
    }
}
