using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaryM<int, string> plakaSehir = new MyDictionaryM<int, string>();
            plakaSehir.Add(57, "Sinop");
            plakaSehir.Add(52, "Ordu");

            plakaSehir.ShowList();
        }
    }
}
