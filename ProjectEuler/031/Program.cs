using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031
{
    class Program
    {
        static void Main(string[] args)
        {

int l2 = 200;
int ways = 1; // 1xL2
for (int l1 = 0; l1 <= 200; l1 += 100)
{
    for (int p50 = 0; p50 <= 200; p50 += 50)
    {
        if (l1 + p50 > 200) { break; }
        for (int p20 = 0; p20 <= 200; p20 += 20)
        {
            if (l1 + p50 + p20 > 200) { break; }
            for (int p10 = 0; p10 <= 200; p10 += 10)
            {
                if (l1 + p50 + p20 + p10 > 200) { break; }
                for (int p5 = 0; p5 <= 200; p5 += 5)
                {
                    if (l1 + p50 + p20 + p10 + p5 > 200) { break; }
                    for (int p2 = 0; p2 <= 200; p2 += 2)
                    {
                        if (l1 + p50 + p20 + p10 + p5 + p2 > 200) { break; }
                        for (int p1 = 0; p1 <= 200; p1 += 1)
                        {
                            if (l1 + p50 + p20 + p10 + p5 + p2 + p1 > 200) { break; }
                            if (l1 + p50 + p20 + p10 + p5 + p2 + p1 == l2) { ways++; }
}   }   }   }   }   }   }
Console.WriteLine(ways);
        }
    }
}
