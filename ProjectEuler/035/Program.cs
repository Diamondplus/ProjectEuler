using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035
{
    class Program
    {
    static HashSet<int> circularPrimes = new HashSet<int>();

    static void Main()
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        int[] elements = { 1, 3, 5, 7, 9 };
        for (int k = 1; k < 7; k++)
        {
            int[] pos = new int[k];
            CombinationsWithRepetitions(elements, k, pos, 0);                
        }
        Console.WriteLine(circularPrimes.Count);
        stopWatch.Stop();

        Console.WriteLine(stopWatch.ElapsedMilliseconds.ToString());
    }

    static void CombinationsWithRepetitions(int[] elements, int m, int[] pos, int depth)
    {
        if (depth >= m)
        {
            int testNumber = 0;
            for (int i = 0; i < m; i++)
            {
                testNumber += elements[pos[i]] * (int)Math.Pow(10, m-i-1);
            }
            if (! circularPrimes.Contains(testNumber))
            {
                IsCircularPrime(testNumber);                   
            }
            return ;
        }
        for (int i = 0; i < elements.Length; i++)
        {
            pos[depth] = i;
            CombinationsWithRepetitions(elements, m, pos, depth + 1);
        }
        return;
    }

    static void IsCircularPrime( int number)
    {
        HashSet<int> allRotations = new HashSet<int>();
        allRotations.Add(number);
        int digitCount = number.ToString().Count();
        int newRotation = number;
        bool isAllRotationsPrimes = true;
        if (IsPrime(number))
        {
            for (int i = 1; i < digitCount; i++)
            {
                int leftDigit = newRotation / (int)Math.Pow(10, digitCount - 1);
                newRotation = newRotation * 10 + leftDigit - leftDigit * (int)Math.Pow(10, digitCount);
                allRotations.Add(newRotation);
                if (!IsPrime(newRotation))
                {
                    isAllRotationsPrimes = false;
                    break;
                }
            }
        }
        else
        {
            isAllRotationsPrimes = false;
        }

        if (isAllRotationsPrimes)
        {
            foreach (int rotation in allRotations)
            {
                circularPrimes.Add(rotation);
                Console.WriteLine(rotation);
            }               
        }
    }

    static bool IsPrime(int number)
    {
        for (int i = 3; i <= Math.Sqrt(number); i++)
        {
            if (number%i==0)
            {
                return false;
            }
        }
        return true;      
    }
    }
}
