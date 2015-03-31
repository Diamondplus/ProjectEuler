using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            HashSet<long> pentDigits = new HashSet<long>();
            int numberOfPentDigits = 10000;

            for (int i = 1; i < numberOfPentDigits; i++)
            {
                int digit = (i*(3*i - 1))/2;
                pentDigits.Add(digit);
            }

            long minD = int.MaxValue;
            bool isFound = false;

            foreach (var firstDigit in pentDigits)
            {
                if (isFound)
                {
                    break;
                }
                foreach (var secondDigit in pentDigits)
                {
                    if (secondDigit <= firstDigit)
                    {
                        continue;
                    }

                    long d = secondDigit - firstDigit;
                    if (pentDigits.Contains(d))
                    {
                        if (pentDigits.Contains(firstDigit + secondDigit))
                        {
                            Console.WriteLine("Ok for: " + firstDigit + " " + secondDigit);
                            if (d < minD)
                            {
                                minD = d;
                                isFound = true;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(minD);
        }
    }
}

