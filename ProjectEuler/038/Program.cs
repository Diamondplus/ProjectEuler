using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038
{
    class Program
    {

        static void Main()
        {
            int[] digits = new int[9];
            for (int i = 9183; i <= 9876; i++)
            {
                int testDigit = i * 100002;
                for (int d = 0; d < 9; d++) 
                { 
                    digits[d] = (testDigit / (int)Math.Pow(10, 9 - d - 1)) % 10; 
                }
                Array.Sort(digits);
                string arrayInString = String.Empty;
                for (int d = 0; d < 9; d++) { arrayInString += digits[d]; }
                if (arrayInString == "123456789") 
                { Console.WriteLine(testDigit); }
            }
        }
    }
}
