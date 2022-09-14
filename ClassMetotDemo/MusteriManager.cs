using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri> { };

        public void Add(Musteri musteri)
        {
            musteriler.Add(musteri);
        }

        public void Show()
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad);
            }
        }

        public void Delete(Musteri musteri)
        {
            musteriler.Remove(musteri);
        }
    }
}
