using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfOkDigits = 3;
            int okDigits = 0;
            for (long i = 1; okDigits != numbersOfOkDigits; i++)
            {
                if (isTriangleNumber(i) && isPentagonalNumber(i) && isHexagonalNumber(i))
                {
                    Console.WriteLine( i );
                    okDigits++;
                }
            }
        }

        //  536870913 ??? int -> long
        // 1533776805 long

        static bool isTriangleNumber(long number)
        {
            bool isTriangleNumber = false;
            // n(n+1)/2
            // n^2 + n - 2*number = 0

            double x = (-1 + Math.Sqrt(1 + 8*number))/2;
            if (x%1==0)
            {
                isTriangleNumber = true;
            }
            return isTriangleNumber;
        }

        static bool isPentagonalNumber(long number)
        {
            bool isPentagonalNumber = false;
            // n(3n-1)/2
            // 3n^2 - n - 2*number = 0

            // x = (-b +- Math.Sqrt(b^2 - 4*a*c) ) / 2*a
            double x = ( 1 + Math.Sqrt( 1 + 24 * number)) / 6;
            if (x % 1 == 0)
            {
                isPentagonalNumber = true;
            }
            return isPentagonalNumber;
        }

        static bool isHexagonalNumber(long number)
        {
            bool isHexagonalNumber = false;
            // n(2n-1)
            // 2n^2 - n - number = 0

            // x = (-b +- Math.Sqrt(b^2 - 4*a*c) ) / 2*a
            double x = (1 + Math.Sqrt(1 + 8 * number)) / 4;
            if (x % 1 == 0)
            {
                isHexagonalNumber = true;
            }
            return isHexagonalNumber;
        }
    }
}
