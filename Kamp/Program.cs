using System;
using System.Collections.Generic;

namespace Kamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = Convert.ToInt32(Console.ReadLine());
            int basamak = 0;

            while(sayi>0)
            {
                sayi = sayi / 10;
                basamak++;
                
            }
            Console.WriteLine(basamak.ToString());
        }
    }
}
