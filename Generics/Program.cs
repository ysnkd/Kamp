using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ornek
            List<string> sehirler = new List<string>();
            
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");

            Console.WriteLine(sehirler2.Count);


        }
    }

    //kendimize özel List sınıfı yapıyoruz.

    class MyList<T> //Generic Class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0]; //Classı her çağrışımızda bize yeni bir liste hazırlıyor. bunun için her atamada 0 elamanlıyla başlatıyoruz.
        }
        public void Add(T item)
        {
            _array = new T[_array.Length + 1]; //Eleman sayısı +1 olmalı. Çünkü 1. eleman, dizinin 0. elemanı.
            // dizide her newlediğimde veriler siliniyor.bunun için _tempArray diye geçici dizi kullanıyoruz.
            _tempArray = _array; // geçici dizi
            for (int i = 0; i < _tempArray.Length; i++) //tempArray'a geleceği için veriler. sayacın uzunlugunu tempArray'e gore aldık.
            {
                _array[i] = _tempArray[i]; //array'i yenilediğimiz için her gelen son eleman tempArray'e geçici olarak atansın.
            }
            _array[_array.Length - 1] = item; //son elemana item gelsin
        }
        public int Count //eleman sayısı metodu. get metodu
        {
            get { return _array.Length; }

        }
    }
}
