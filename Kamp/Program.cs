using System;
using System.Collections.Generic;

namespace Kamp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kurslar = new List<string> { };

            kurslar.Add(".NET");
            kurslar.Add("Java");
            kurslar.Add("Angular");

            foreach (var item in kurslar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
