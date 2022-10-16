using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(1, 2);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(3, 4)); 
            //çalışma anında yapamaz mıyım?

            var type = typeof(DortIslem);

            //DortIslem dortislem = (DortIslem)Activator.CreateInstance(type,6,7);//çalışma anında dortislem newledi
            //CreateInstance: çalışma anında instance üretme
            //Console.WriteLine(dortislem.Topla(2, 5));
            //Console.WriteLine(dortislem.Topla2());
            //Console.ReadLine();

           // var instance = Activator.CreateInstance(type, 6, 7);
           // Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance,null)); //metoda ulaşma
            //GETMETHOD: METOT GETİRİYOR.
            //INVOKE: GETİRİLEN METODU ÇALIŞTIR.

            var metodlar = type.GetMethods();
            //metot info ve metodun parametreleri ulaşma.
            foreach (var info in metodlar)  
            {
                Console.WriteLine("Metot Adı: {0}",info.Name);
                foreach (var getParams in info.GetParameters())
                {
                    Console.WriteLine("Parametresi: {0}",getParams);
                }
                //ATTRIBUTE
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute: {0}",attribute);
                }
            }
            
        }
    }
    class DortIslem
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1,int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MetodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }
    public class MetodNameAttribute:Attribute
    {
        public MetodNameAttribute(string name)
        {

        }
    }
}
