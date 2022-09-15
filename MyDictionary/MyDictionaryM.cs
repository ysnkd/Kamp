using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{


    class MyDictionaryM<T, K>
    {
        KeyValuePair<T, K>[] items; //KeyValuePair int,string veritipi.

        //CONSTRUCTOR

        public MyDictionaryM()
        {
            items = new KeyValuePair<T, K>[0];
        }
        public void Add(T key, K value)
        {
            KeyValuePair<T, K>[] tempArray = items; //Geçici DİZİ
            items = new KeyValuePair<T, K>[tempArray.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //Geçici dizideki elemanları alıp asıl dizimize geri koyduk.

            }
            items[items.Length - 1] = new KeyValuePair<T, K>(key, value); // En son bize gelen değeri dizimize aktarıp işi bitirdik.

        }
        public void ShowList()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

    }
}  


