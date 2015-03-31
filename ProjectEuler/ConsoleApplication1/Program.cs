using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimension = 1001;
            int diagonalSum = 1;

            for (int i = 3; i <= dimension; i=i+2)
            {
                for (int k = 1; k <= 4; k++)
                {
                    int nextDiagonalDigit = (i-2)*(i-2) + k*i - k;
                    Console.WriteLine("{0} {1} : {2}", i, k, nextDiagonalDigit);
                    diagonalSum += nextDiagonalDigit;
                }  
            }

            Console.WriteLine("Matrix: {0}x{0} --> Diagonal sum = {1}", dimension, diagonalSum);
            Console.WriteLine();
        }
    }
}
