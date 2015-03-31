using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041
{
    class Program
    {
        static void Main()
        {
            List<int> elements = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            int[] pos = new int[elements.Count];
            Variations(elements, pos, 0);
        }

        static void Variations(List<int> elements, int[] pos, int depth)
        {
            if (depth >= elements.Count)
            {
                IsPrime(elements, pos);
                return;
            }

            for (int i = 0; i < elements.Count; i++)
            {
                bool isElementExist = false;
                for (int d = 0; d < depth; d++)
                {
                    if (pos[d] == i)
                    {
                        isElementExist = true;
                        break;
                    }
                }
                if (!isElementExist)
                {
                    pos[depth] = i;
                    Variations(elements, pos, depth + 1);
                }
            }
            return;
        }

        static bool IsPrime( List<int> elements, int[] pos)
        {
            long digit = 0;
            for (int i = 0; i < elements.Count; i++)
            {
                digit += elements[pos[i]] * (long)Math.Pow(10, elements.Count - i -1);
            }

            for (int i = 2; i < Math.Sqrt(digit); i++)
            {
                if (digit%i==0)
                {
                    return false;
                }
            }
            Console.WriteLine(digit);
            return true;
        }
    }
}
