using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036
{
    class Program
    {
    static void Main(string[] args)
    {
        int sum = 0;
        for (int i = 1; i < 1000000; i++)
        {
            if (IsPalindromic10(i) && IsPalindromic2(i))
            {
                Console.WriteLine(i);
                sum += i;
            }
        }
        Console.WriteLine("Sum = {0}", sum);
    }

    private static bool IsPalindromic10(int i)
    {
        string digit = i.ToString();

        for (int pos = 0; pos < digit.Length / 2; pos++)
        {
            if (!(digit.Substring(pos, 1) == digit.Substring(digit.Length - pos - 1, 1)))
            {
                return false;
            }
        }
        return true;
    }

    private static bool IsPalindromic2(int i)
    {
        string digit = Convert.ToString(i, 2);
        for (int pos = 0; pos < digit.Length / 2; pos++)
        {
            if (!(digit.Substring(pos, 1) == digit.Substring(digit.Length - pos - 1, 1)))
            {
                return false;
            }
        }
        return true;
    }
    }
}
