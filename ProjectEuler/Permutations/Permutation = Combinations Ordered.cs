using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Permutations_Nelements_Kclass
{
    class Permutations_Nelements_Kclass
    {
        static int count = 0;
        static int PermutationsN(int[] elements, int m, int[] pos, bool[] used, int dept)
        {
            if (dept >= m)
            {
                for (int i = 0; i < m; i++)
                {
                    Console.Write("{0} ", elements[pos[i]]);
                }
                count++;
                Console.WriteLine();
                return count;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (used[i])
                {
                    continue;
                }
                used[i] = true;
                pos[dept] = i;
                PermutationsN(elements, m, pos, used, dept + 1);
                used[i] = false;
            }
            return count;
        }

        static void Main()
        {
            // Permutation elemnents K class
            int[] elements = { 2,2,3,5};
            int K = 3;

            int[] pos = new int[elements.Length];
            bool[] used = new bool[elements.Length]; // fill false
            int depth = 0;
            PermutationsN(elements, K, pos, used, depth);
            Console.WriteLine("\nPermutations of {0} elemets and class {1}  = {2}\n", elements.Length, K, count);
        }
    }
}
