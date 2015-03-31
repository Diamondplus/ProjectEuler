using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeNumbers = new List<int>() { 1, 2};

            int maxPrimeFormula = 2100000; // 1000^2 + 1000*1000 + 1000 = 2100000
            for (int i = 3; i < maxPrimeFormula; i = i + 2)
            {
                bool isPrime = true;
                for (int k = 3;  k <= Math.Sqrt(i) ; k++)
                {
                    if ( i%k==0 )
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime) { 
                    primeNumbers.Add(i);
                   // Console.WriteLine("Add {0}th number : {1}", primeNumbers.Count, i);
                }            
            }
            Console.WriteLine("{0} private numbers under {1}", primeNumbers.Count, maxPrimeFormula);
            
            // 169 prime numbers < 1000
            int quantity = 169;

            int maxCount = 1;
            int maxA = 1;
            int maxB = 1;
            for (int a = 0; a < quantity; a++)
            {
                Console.WriteLine(a);
                for (int b = 0; b < quantity; b++)
                {

                    // n^2 + a*n + b 
                    int i = 1;
                    bool primeFlag = true;
                    do
                    {
                        int sum = (int)Math.Abs( i * i + primeNumbers[a] * i + primeNumbers[b]);
                        if (! primeNumbers.Contains(sum))
                        {
                            if ( maxCount <= i )
                            {
                                maxCount = i;
                                maxA = primeNumbers[a];
                                maxB = primeNumbers[b];
                                Console.WriteLine();
                                Console.WriteLine("a = {0} b = {1}", primeNumbers[a], primeNumbers[b]);
                                Console.WriteLine("++{0}", maxCount);
                            }
                            primeFlag = false;
                        }
                        i++;
                    } while (primeFlag);

                    
                    // n^2 + a*n - b 
                    i = 1;
                    primeFlag = true;
                    do
                    {
                        int sum = (int)Math.Abs(i * i + primeNumbers[a] * i - primeNumbers[b]);
                        if (!primeNumbers.Contains(sum))
                        {
                            if (maxCount <= i)
                            {
                                maxCount = i;
                                maxA = primeNumbers[a];
                                maxB = primeNumbers[b];
                                Console.WriteLine();
                                Console.WriteLine("a = {0} b = {1}", primeNumbers[a], primeNumbers[b]);
                                Console.WriteLine("+-{0}", maxCount);
                            }
                            primeFlag = false;
                        }
                        i++;
                    } while (primeFlag);

                    // n^2 - a*n + b 
                    i = 1;
                    primeFlag = true;
                    do
                    {
                        int sum = (int)Math.Abs(i * i - primeNumbers[a] * i + primeNumbers[b]);
                        if (!primeNumbers.Contains(sum))
                        {
                            if (maxCount <= i)
                            {
                                maxCount = i;
                                maxA = primeNumbers[a];
                                maxB = primeNumbers[b];
                                Console.WriteLine();
                                Console.WriteLine("a = {0} b = {1}", primeNumbers[a], primeNumbers[b]);
                                Console.WriteLine("-+{0}", maxCount);
                            }
                            primeFlag = false;
                        }
                        i++;
                    } while (primeFlag);

                    // n^2 - a*n - b 
                    i = 1;
                    primeFlag = true;
                    do
                    {
                        int sum = (int)Math.Abs(i * i - primeNumbers[a] * i - primeNumbers[b]);
                        if (!primeNumbers.Contains(sum))
                        {
                            if (maxCount <= i)
                            {
                                maxCount = i;
                                maxA = primeNumbers[a];
                                maxB = primeNumbers[b];
                                Console.WriteLine();
                                Console.WriteLine("a = {0} b = {1}", primeNumbers[a], primeNumbers[b]);
                                Console.WriteLine("--{0}", maxCount);
                            }
                            primeFlag = false;
                        }
                        i++;
                    } while (primeFlag);



                }
            }

            Console.WriteLine("MaxCount = {0}", maxCount);
            Console.WriteLine("A = {0}", maxA);
            Console.WriteLine("B = {0}", maxB);
            Console.WriteLine("A * B = {0}", maxA*maxB);

        }
    }
}
