using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Divide(2, 0);
        }

        static int Divide(int first, int second)
        {
            int result = 0;

            try
            {
                result = first / second;
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero, please provide a non-zero value for your second value");
            }

            return result;
        }
    }
}
