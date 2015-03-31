using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Dictionary<int, int> perimeterSolutions = new Dictionary<int, int>();
            int maxP = 120;
            for (int p = 120; p < 1001; p++)
            {
                for (int a = p/2; a > 0; a--)
                {
                    for (int b = p/2; b > 0; b--)
                    {
                        if (a+b<p/2)
                        {
                            break;
                        }
                        else if (a+b+Math.Sqrt( Math.Pow(a,2)+ Math.Pow(b,2))==p)
                        {
                            if (!perimeterSolutions.ContainsKey(p))
                            {
                                perimeterSolutions.Add(p, 1);
                            }
                            else
                            {
                                perimeterSolutions[p]++;
                                if (perimeterSolutions[p] > perimeterSolutions[maxP])
                                {
                                    maxP = p;
            }   }   }   }   }   }
            Console.WriteLine("P = {0} Max solutions = {1}", maxP, perimeterSolutions[maxP]);
            stopWatch.Stop();
            Console.WriteLine("Time : {0}", stopWatch.Elapsed.ToString());
        }
    }
}
