using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace All_deviders
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> deviders = new List<int>();
            for (int i = 2; i < 100; i++)
            {
                deviders = FindDivisors(i);
                int count = deviders.Count;
                Console.WriteLine("Digit: {0} Deviders", i,count);
                for (int j = 0; j < count; j++)
                {
                    Console.Write("{0} ", deviders[j]);
                }
                deviders.Clear();
                string pause = Console.ReadLine();
            }
        }

        public static List<int> FindDivisors(int x)
        {
            List<int> toreturn = new List<int>();
            List<int> remainders = new List<int>();
            double margin = Math.Floor(Math.Sqrt(x));
            for (int i = 2; i <= margin; i++)
            {
                if (x % i == 0)
                {
                    toreturn.Add(i);
                    remainders.Add(x / i);
                }
            }

            int count = remainders.Count;
            for (int i = 0; i < count; i++)
            {
                toreturn.Add(remainders[count - i - 1]);
            }

            if (margin*margin==x)
            {
                toreturn.Remove((int)margin);
            }
            return toreturn;
        }
    }
}
