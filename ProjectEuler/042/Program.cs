using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042
{
    class Program
    {
        static void Main()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int counter = 0;
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\words.txt";
            char[] delimiterChars = { ',', '"', '"' };
            string allWords = string.Empty;
            if (File.Exists(path))
            { using (StreamReader sr = File.OpenText(path)) { allWords = sr.ReadLine(); }}
            string[] words = allWords.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < words.Count(); i++)
            {
                if (IsTriangleWord(words[i])) { counter++; };
            }
            Console.WriteLine("There are : {0} triangle words!", counter);
            stopWatch.Stop();
            Console.WriteLine("Time : {0}", stopWatch.Elapsed.ToString());
        }

        static bool IsTriangleWord(string word)
        {
            int value = 0;
            for (int i = 0; i < word.Length; i++)
            {
                int charValue = ((int)word.Substring(i, 1)[0] - 64);
                value += charValue;
            }
            int n = (int)Math.Sqrt(value*2);
            if (n*(n+1)==2*value ) { return true; }
            return false;
        }
    }
}
