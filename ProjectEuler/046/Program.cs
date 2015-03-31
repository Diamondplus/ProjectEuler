using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNotFound = true;

            for (int i = 3; isNotFound; i=i+2)
            {
                if (!isPrime(i))
                {
                    if (! isDigittOk(i))
                    {
                       Console.WriteLine(  i);
                        isNotFound = false;
                    }            
                }
            }
        }

        private static bool isDigittOk(int digit)
        {
            bool isDigitOk = false;

            for (int i = 1; 2*i*i < digit; i++)
            {
                if (isPrime(digit - 2*i*i))
                {
                    isDigitOk = true;
                    break;
                }
            }
            return isDigitOk;
        }

        private static bool isPrime(int rest)
        {
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(rest); i++)
            {
                if (rest%i==0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}
