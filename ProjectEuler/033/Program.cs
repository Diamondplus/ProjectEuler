using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033
{
    class Program
    {
        static void Main(string[] args)
        {

    for (int num = 10; num < 99; num++)
    {
        for (int denom = num+1; denom <= 99; denom++)
        {
            int nom0 = num%10;
            int nom1 = (num / 10) % 10;
            int denom0 = denom % 10;
            int denom1 = (denom / 10) % 10;

            decimal nomDenomDiv = (decimal)num / (decimal)denom;

            if (nom0==0 && denom0==0) {  continue; }

            if (nom0==denom0)
            {
                if ((decimal)num / (decimal)denom == (decimal)nom1 / (decimal)denom1)
                {
                    Console.WriteLine("{0}/{1} = {2}/{3}", num, denom, nom1, denom1);
                }
            }

            if ( nom0==denom1 && denom0!=0)
            {
                if ( nomDenomDiv == (decimal)nom1 / (decimal)denom0)
                {
                    Console.WriteLine("{0}/{1} = {2}/{3}", num, denom, nom1, denom0);
                }
            }

            if (nom1 == denom0 && denom1 !=0)
            {
                if (nomDenomDiv == (decimal)nom0 / (decimal)denom1)
                {
                    Console.WriteLine("{0}/{1} = {2}/{3}", num, denom, nom0, denom1);
                }
            }


            if (nom1 == denom1 && denom0!=0)
            {
                if (nomDenomDiv == (decimal)nom0 / (decimal)denom0)
                {
                    Console.WriteLine("{0}/{1} = {2}/{3}", num, denom, nom0, denom0);
                }
            }
        }
    }
        }
    }
}
