using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {

        static int count = 0;
        static int Variations(List<int> elements, int m, int[] pos, int depth, int margin )
        {
            if (depth >= m)
            {
                for (int i = 0; i < m; i++)
                {
                    Console.Write("{0} ", elements[pos[i]]);
                }
                Console.WriteLine();
                count++;

                return count;
            }

            for (int i = margin; i < elements.Count; i++)
            {

                    pos[depth] = i;
                    Variations(elements, m, pos, depth + 1, margin);    
                      
            }
            return count;
        }

        static void Main()
        {
            // Ordred Combination with repetitions - N elements K class
            List<int> elements = new List<int>(){ 1, 2, 3 };
            int k = 5;

            int[] pos = new int[k];
            int depth = 0;
            int margin = 0;
            Variations(elements, k, pos, depth, margin );
            Console.WriteLine("\nVariations V(n={0})(k={1})=\nORDERED Combinations with Repetitions of {0} elemets and class {1}  = {2}\n", elements.Count, k, count);
        }

        
    }
}
