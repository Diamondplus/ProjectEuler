using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _047
{
    class Program
    {
        static HashSet<int> differentDividers = new HashSet<int>();

        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 1; ; i++)
            {
                differentDividers.Clear();
                FindNumbersOfDifferentPrimeDeviders(i);
                if (differentDividers.Count==4)
                {
                    differentDividers.Clear();
                    FindNumbersOfDifferentPrimeDeviders(i+1);
                    if (differentDividers.Count == 4)
                    {
                        differentDividers.Clear();
                        FindNumbersOfDifferentPrimeDeviders(i + 2);
                        if (differentDividers.Count == 4)
                        {
                            differentDividers.Clear();
                            FindNumbersOfDifferentPrimeDeviders(i + 3);
                            if (differentDividers.Count == 4)
                            {
                                Console.WriteLine(i);
                                break;
                            }
                        }
                    }
                }
            }
            stopWatch.Stop();
            Console.WriteLine("Time : {0}", stopWatch.Elapsed.ToString());
        }

        public static void FindNumbersOfDifferentPrimeDeviders(int digit)
        {
            if (isPrime(digit))
            {
                differentDividers.Add(digit);
            }
            else
            {
                int smallestDivider = 1;
                bool isRestNotPrime = true;
                do
                {
                    smallestDivider = SmalestDivider(digit);
                    differentDividers.Add(smallestDivider);
                    digit = digit/smallestDivider;
                    if (isPrime(digit))
                    {
                        differentDividers.Add(digit);
                        isRestNotPrime = false;
                    }
                } while (isRestNotPrime);
            }
        }

        public static int SmalestDivider(int digit)
        {
            int smalestDivider = 2;
            for (int i = 2; i <= Math.Sqrt(digit); i++)
            {
                if (digit % i == 0)
                {
                    smalestDivider = i;
                    break;
                }
            }
            return smalestDivider;
        }

        private static bool isPrime(int rest)
        {
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(rest); i++)
            {
                if (rest % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
