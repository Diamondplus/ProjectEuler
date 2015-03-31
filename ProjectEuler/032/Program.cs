using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032
{
    class Program
    {
        static HashSet<int> uniqueProducts = new HashSet<int>();
        static void Main()
        {
            List<int> elements = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int[] pos = new int[elements.Count];
            Variations( elements, pos, 0);       
            Console.WriteLine("ProductsSum = {0}", uniqueProducts.Sum());
        }

        static void Variations(List<int> elements, int[] pos, int depth)
        {
            if (depth >= elements.Count)
            {
                CheckPandigital(elements, pos);
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

        static void CheckPandigital( List<int> elements, int[] pos)
        {
            int multiplicand = elements[pos[0]];
            int multiplier = elements[pos[1]] * 1000 + elements[pos[2]] * 100 + elements[pos[3]] * 10 + elements[pos[4]];
            int product =  elements[pos[5]] * 1000 + elements[pos[6]] * 100 + elements[pos[7]] * 10 + elements[pos[8]];
            if ( multiplicand * multiplier == product)
            {
               // Console.WriteLine("{0} * {1}{2}{3}{4} = {5}{6}{7}{8}", elements[pos[0]], elements[pos[1]], elements[pos[2]], elements[pos[3]], elements[pos[4]], elements[pos[5]], elements[pos[6]], elements[pos[7]], elements[pos[8]]);
               uniqueProducts.Add( product) ;
            }
            multiplicand = elements[pos[0]] * 10 + elements[pos[1]];
            multiplier = elements[pos[2]] * 100 + elements[pos[3]] * 10 + elements[pos[4]];
            product = elements[pos[5]] * 1000 + elements[pos[6]] * 100 + elements[pos[7]] * 10 + elements[pos[8]];
            if (multiplicand * multiplier == product)
            {
                // Console.WriteLine("{0}{1} * {2}{3}{4} = {5}{6}{7}{8}", elements[pos[0]], elements[pos[1]], elements[pos[2]], elements[pos[3]], elements[pos[4]], elements[pos[5]], elements[pos[6]], elements[pos[7]], elements[pos[8]]);
                uniqueProducts.Add(product);
            }
        }
    }
}
