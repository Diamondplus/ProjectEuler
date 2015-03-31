using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Combinations_with_repetitions_Nelement_Kclass
{
    class Combinations_with_repetitions_Nelement_Kclass
    {
        static int count = 0;
        static int CombinationsNRepeat(int[] elements, int m, int[] pos, int depth, int margin)
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

            for (int i = margin; i < elements.Length; i++)
            {
                pos[depth] = i;
                CombinationsNRepeat(elements, m, pos, depth + 1, i);
            }
            return count;
        }

        static void Main()
        {
            // Combination with repetitions N elements K class
            int[] elements = { 1, 2, 3, 4 };
            int K = 3;

            int[] pos = new int[elements.Length];
            int depth = 0;
            int margin = 0;
            CombinationsNRepeat(elements, K, pos, depth, margin);
            Console.WriteLine("\nCombinations with Repetitions of {0} elemets and class {1}  = {2}\n", elements.Length, K, count);
        }

    }
}
