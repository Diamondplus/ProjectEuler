using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _048
{
    class Program
    {
static void Main(string[] args)
{
    Stopwatch stopWatch = new Stopwatch();
    stopWatch.Start();
    BigInteger sum = 0;
    for (int i = 1; i < 1001; i++)
    {
        BigInteger power = 1;
        for (int j = 0; j < i; j++)
        {
            power = power*i;
        }
        sum = sum + power;
    }
    Console.WriteLine(sum%10000000000);
    stopWatch.Stop();
    Console.WriteLine("Time : {0}", stopWatch.Elapsed.ToString());
}
    }
}
