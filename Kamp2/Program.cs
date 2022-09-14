using System;

namespace Kamp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Apple";
            product1.Price = 25;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Banana";
            product2.Price = 34;

            Product product3 = new Product();
            product3.Id = 3;
            product3.Name = "Melon";
            product3.Price = 42;

            Product[] products = new Product[] { product1, product2, product3 };

            //For döngüsü

           

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Name);
            }

            //foreach 

            foreach (var x in products)
            {
                Console.WriteLine(x.Id);
            }

            //while döngüsü

            int sayac = 0;

            while(sayac<products.Length)
            {
                Console.WriteLine(products[sayac].Price);
                sayac++;
                
            }

        }
    }
}
