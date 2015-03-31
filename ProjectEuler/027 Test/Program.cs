using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeNumbers = new List<int>() { 1, 2 };

            int maxPrimeFormula = 20000; // 1000^2 + 1000*1000 + 1000 = 2100000
            for (int i = 3; i < maxPrimeFormula; i = i + 2)
            {
                bool isPrime = true;
                for (int k = 3; k <= Math.Sqrt(i); k++)
                {
                    if (i % k == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primeNumbers.Add(i);
                    //Console.WriteLine("Add {0}th number : {1}", primeNumbers.Count, i);
                }
            }
            Console.WriteLine("{0} private numbers under {1}", primeNumbers.Count, maxPrimeFormula);

            int a = 1;
            int b = 41;
            int count = 0;

            for (int i = 0; i <= primeNumbers[a]; i++)
            {
                bool primeFlag = true;
                int sum = i * i + primeNumbers[a] * i + primeNumbers[b];
                if (!primeNumbers.Contains(sum))
                {
                    if (maxCount < i - 1)
                    {
                        maxCount = i - 1;
                        maxA = primeNumbers[a];
                        maxB = primeNumbers[b];
                        Console.WriteLine();
                        Console.WriteLine("a = {0} b = {1}", primeNumbers[a], primeNumbers[b]);
                        Console.WriteLine("++{0}", maxCount);

                    }
                }
                else
                {
                    continue;
                }
                break;
            }



        }
    }
}
