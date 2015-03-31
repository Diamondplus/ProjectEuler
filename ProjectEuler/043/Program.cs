using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _043
{
    class Program
    {
        static long sum = 0;
        static void Main()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            List<int> elements = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 ,9 ,0 };
            int[] pos = new int[elements.Count];
            Variations(elements, pos, 0);
            Console.WriteLine("Sum = {0}",sum);
            stopWatch.Stop();
            Console.WriteLine("Time = {0}",stopWatch.Elapsed.ToString());
        }

        static void Variations(List<int> elements, int[] pos, int depth)
        {
            if (depth >= elements.Count)
            {
                if (elements[pos[0]]!=0)
                {
                    if ((elements[pos[1]]*100+elements[pos[2]]*10+elements[pos[3]])%2==0)
	                {
		                if ((elements[pos[2]]*100+elements[pos[3]]*10+elements[pos[4]])%3==0)
                        {
                            if ((elements[pos[3]]*100+elements[pos[4]]*10+elements[pos[5]])%5==0)
                            {
                                if ((elements[pos[4]]*100+elements[pos[5]]*10+elements[pos[6]])%7==0)
                                {
                                    if ((elements[pos[5]]*100+elements[pos[6]]*10+elements[pos[7]])%11==0)
                                    {
                                        if ((elements[pos[6]]*100+elements[pos[7]]*10+elements[pos[8]])%13==0)
                                        {
                                            if ((elements[pos[7]]*100+elements[pos[8]]*10+elements[pos[9]])%17==0)
                                            {
                                                long testNumber = 0;
                                                for (int i = 0; i < elements.Count; i++)
                                                {                          
                                                    testNumber += elements[pos[i]] * (long)Math.Pow(10, elements.Count - i - 1);
                                                }
                                                sum+=testNumber;
                                            }
                                        }
                                    }
                                }
                            }
                        }
	                }
                }
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

