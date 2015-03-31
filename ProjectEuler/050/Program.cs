using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _050
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue = 100;
            int maxSum = 0;
            int maxCount = 0;
            int currentSum = 0;
            int currentCount = 0;
            for (int i = 1; i < maxValue; i = i + 2)
            {
                if (IsPrime(i))
                {
                    currentCount++;
                    currentSum += i;
                    Console.Write( "{0}-", i );
                }
                else
                {
                    if (currentCount>maxCount)
                    {
                        maxCount = currentCount;
                        maxSum = currentSum;
                    }
                    currentCount = 0;
                    currentSum = 0;
                }
                Console.WriteLine(  );
            }

            Console.WriteLine( "Max count :{0}", maxCount );
            Console.WriteLine( "Max Sum :{0}", maxSum);

            Console.ReadKey();
        }

        public static bool IsPrime(int number)
        {
            bool result = true;
            double margin = Math.Floor(Math.Sqrt(number));
            for (int i = 2; i <= margin; i++)
            {
                if (number%i==0)
                {
                    return false;            
                }
            }

            return result;
        }
    }
}
