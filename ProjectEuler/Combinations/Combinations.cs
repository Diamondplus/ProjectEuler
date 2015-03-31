using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Combinations
{
    class Combinations
    {
        static int count = 0;
        static int CombinationsN(int[] elements, int m, int[] pos, int depth, int margin)
        {
            {
                if (depth >= m)
                {
                    for (int i = 0; i < m; i++)
                    {
                        Console.Write("{0} ", elements[pos[i]]);
                    }
                    count++;
                    Console.WriteLine();
                    return count;
                }

                if ((elements.Length - margin) < (m - depth))
                {
                    return count;
                }

                for (int i = margin; i < elements.Length; i++)
                {
                    pos[depth] = i;
                    CombinationsN(elements, m, pos, depth + 1, i + 1);
                }
                return count;
            }
        }

        static void Main()
        {
            // Combinations of N element K class
            int[] elements = { 2, 2, 3, 5};
            int K = 2;

            int[] pos = new int[elements.Length];
            int depth = 0;
            int margin = 0;
            CombinationsN(elements, K, pos, depth, margin);
            Console.WriteLine("\nCombinations of {0} elemets and class {1}  = {2}\n", elements.Length, K, count);
        }
    }
}
