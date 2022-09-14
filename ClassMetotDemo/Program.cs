using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Yasin";
            musteri1.Soyad = "Kol";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);

            musteriManager.Show();
        }
    }
}
