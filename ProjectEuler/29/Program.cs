using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace _29
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<double> distincts = new HashSet<double>();
            for (int a = 2; a <= 100; a++)
            {
                for (int b = 2; b <= 100; b++)
                {
                    distincts.Add(Math.Pow(a, b));
                }
            }
            Console.WriteLine(distincts.Count());
        }
    }
}
