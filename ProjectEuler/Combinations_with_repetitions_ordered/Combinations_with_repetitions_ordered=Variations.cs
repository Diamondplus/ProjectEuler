using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Combinations_with_repetitions_Nelement_Kclass_ordered
{
    class Combinations_with_repetitions_Nelement_Kclass_ordered
    {
        static int count = 0;
        static int Variations(int[] elements, int m, int[] pos, int depth, int margin)
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
                Variations(elements, m, pos, depth + 1, margin);
            }
            return count;
        }

        static void Main()
        {
            // Variations = Combination with repetitions ORDERED N elements K class
            int[] elements = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int K = 3;

            int[] pos = new int[elements.Length];
            int depth = 0;
            int margin = 0;
            Variations(elements, K, pos, depth, margin);
            Console.WriteLine("\nVariations V(n={0})(k={1})=\nORDERED Combinations with Repetitions of {0} elemets and class {1}  = {2}\n", elements.Length, K, count);
        }

    }
}
