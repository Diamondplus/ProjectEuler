using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _034
{
    class Program
    {
        static void Main(string[] args)
        {
    int sum = 0;
    int[] factorial = new int[] { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };

    for (int i = 0; i < 10000000; i++)
    {
        int[] digit = new int[7];
        for (int d = 0; d < 7; d++)
        {
            digit[d] = ( i / (int)Math.Pow(10, d)) % 10;
        }

        int factorialSum = 0;
        factorialSum = (i >= 1000000 ? factorial[digit[6]] : 0) + (i >= 100000 ? factorial[digit[5]] : 0) + (i >= 10000 ? factorial[digit[4]] : 0) + (i >= 1000 ? factorial[digit[3]] : 0) + factorial[digit[2]] + factorial[digit[1]] + factorial[digit[0]];
        if ( i == factorialSum)
        {
            Console.WriteLine(i);
            sum += i;
        }
    }
    Console.WriteLine("Sum = {0}", sum);
        }
    }
}
