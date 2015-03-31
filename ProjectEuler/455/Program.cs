using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _455
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1000; i > 1; i--)
            {
                if (i % 10 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
                for (int n = 1000000000; n > 1; n--)
                {
                    if (Power(i, n))
                    {
                        sum += n;
                        Console.WriteLine("f({0}) = {1}", i, n);
                    }
                }
            }

            Console.WriteLine(Power(157, 743757));

        }



        static bool Power( int number, int power)
        {
            long value = 1;
            for (int i = 0; i < power; i++)
            {
                value *= number;
                number %= 1000000000;
                // Console.WriteLine(value);
            }
            Console.WriteLine(value);
            Console.WriteLine(power);
            return (value==power?true:false);
        }
    }
}
