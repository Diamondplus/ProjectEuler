using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordered_Combination_without_rep
{
    class Program
    {
        static void Main()
        {
            List<int> elements = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] pos = new int[elements.Count];
            Variations(elements, pos, 0);
        }

        static void Variations(List<int> elements, int[] pos, int depth)
        {
            if (depth >= elements.Count)
            {
                for (int i = 0; i < elements.Count; i++)
                {
                    Console.Write("{0} ", elements[pos[i]]);
                }
                Console.WriteLine();

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
    }
}
