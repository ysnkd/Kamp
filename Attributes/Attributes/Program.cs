using System;

namespace Attributes
{
    // Reflection Niye kullanılır: Hangi nesneyle, metotla çalışmamızı yönlendirebiliyoruz.
    //nesneler hakkında bilgi almak ÇALIŞMA ANINDA
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                LastName = "Demiroğ",
                Age = 32
            };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
            
        }
    }
    [ToTable("Customers")] //db'de customers'e kayıt
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]//Amaç FirstName'e değer atamak zorunlu 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    class CustomerDal
    {
        [Obsolete("Don't use Add,instead use Addnew Method")] //bu attribute'i kullanan kişi bu class önceden oluşturulduğunu uyarır.
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!",
                customer.Id,customer.FirstName,customer.LastName,customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!",
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }
    //ATTRIBUTES OLUŞTURMA

    [AttributeUsage(AttributeTargets.Property,AllowMultiple =true )]//herkese kullanabilirsin.
    //all yerine class yazarsak sadece bu attribute'i classlarda kullanabilirsin.
    // | property yerine field yazılarak şartlar çoğaltılabilir.
    //AllowMultiple=true; sadece 1 kere değil istediğimiz kadar kullanabiliriz.
    class RequiredPropertyAttribute:Attribute
    {

    }
    [AttributeUsage(AttributeTargets.Class)]
    class ToTableAttribute:Attribute
    {
        private string _tablename;

        public ToTableAttribute(string tablename)
        {
            _tablename = tablename;
        }
    }
}
