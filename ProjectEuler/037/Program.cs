using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037
{
    class Program
    {
    static void Main(string[] args)
    {
        int sum = 0;
        for (int i = 11; i < 1000000; i=i+2)
        {
            if (IsBothTruncatable(i) )
            {
                sum += i;                  
            }
        }
        Console.WriteLine("Sum = {0}", sum);
    }

    private static bool IsBothTruncatable(int i)
    {
        int testNumber = i;
        if (IsPrime(i))
        {
            int numberOfDigit = i.ToString().Count();
            for (int d = 1; d < numberOfDigit; d++)
            {
                int koef = (int)Math.Pow(10, numberOfDigit-d);
                int leftDigit = testNumber / koef;
                testNumber = testNumber - leftDigit * koef;

                if (! IsPrime(testNumber) || testNumber == 1)
                {
                    return false;
                }
            }

            testNumber = i;
            for (int d = 1; d < numberOfDigit; d++)
            {
                testNumber = testNumber / 10;
                if (!IsPrime(testNumber) || testNumber == 1)
                {
                    return false;
                }
            }
            return true;
        }
        return false;
    }

    static bool IsPrime(int number)
    {
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    }
}
