using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040
{
    class Program
    {
        static void Main(string[] args)
        {
    int product = 1;
    int position = 0;
    HashSet<int> positions = new HashSet<int>{1, 10, 100, 1000, 10000, 100000, 1000000 };
    for (int i = 1; position <= 1000000; i++)
    {
        int number = i;
        int digitNumber = i.ToString().Count();
        for (int d = 0; d < digitNumber; d++)
        {
            int currentDigit = i / (int)Math.Pow(10, digitNumber - d - 1) % 10;
            number = number - currentDigit * (int)Math.Pow(10, digitNumber - d - 1);
            position++;
            if (positions.Contains(position))
            {
                product*= currentDigit;
            }
        }
    }
    Console.WriteLine("Product = {0}", product);
        }
    }
}
