using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049
{
    class Program
    {
private static void Main()
{
    Stopwatch stopWatch = new Stopwatch();
    stopWatch.Start();
    HashSet<int> digits1 = new HashSet<int>();
    HashSet<int> digits2 = new HashSet<int>();
    HashSet<int> digits3 = new HashSet<int>();
    for (int numberOfdifferentDigits = 4; numberOfdifferentDigits > 1; numberOfdifferentDigits--)
    {
        for (int i = 1000; i < 10000; i++)
        {
            digits1.Clear();
            digits1.Add(i%10);
            digits1.Add((i/10)%10);
            digits1.Add((i/100)%10);
            digits1.Add((i/1000)%10);
            int digitCount = digits1.Count;
            if (digits1.Count != numberOfdifferentDigits)
            {
                continue;
            }
            if (isPrime(i))
            {
                for (int j = i + 1; j < 10000; j++)
                {
                    digits2.Clear();
                    digits2.Add(j%10);
                    digits2.Add((j/10)%10);
                    digits2.Add((j/100)%10);
                    digits2.Add((j/1000)%10);
                    if (
                        digits2.Count == numberOfdifferentDigits &&
                        digits1.Union(digits2).Count() == numberOfdifferentDigits &&
                        isPrime(j)
                        )
                    {
                        for (int k = j + 1; k < 10000; k++)
                        {
                            digits3.Clear();
                            digits3.Add(k%10);
                            digits3.Add((k/10)%10);
                            digits3.Add((k/100)%10);
                            digits3.Add((k/1000)%10);

                            if (
                                digits3.Count == numberOfdifferentDigits &&
                                digits1.Union(digits3).Count() == numberOfdifferentDigits &&
                                isPrime(k))
                            {
                                if (k - j == j - i)
                                {
                                    Console.WriteLine(i + " " + j + " " + k);
                                }
                            }
                        }
                    }
                }
            }

        }

    }
    stopWatch.Stop();
    Console.WriteLine("Time : {0}", stopWatch.Elapsed.ToString());
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
