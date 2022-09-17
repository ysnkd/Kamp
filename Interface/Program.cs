using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();

            IPerson person = new Costumer();
            //interfaceden bir nesne newlenemez.
            Costumer costumer = new Costumer
            {
                Id = 2,
                    FirstName="Kadir",
                    LastName="Kol",
                    Address="Sinop"
            };

            manager.Add(costumer);

            Student student = new Student
            {
                Id = 1,
                FirstName = "Derin",
                LastName = "Demiroğ",
                Departman = "Computer Sciences"
            };
            //manager.Add(student) Base olmadığı için maalesef Student classı bu metotla bağdaşmıyor. Değer olarak ortak base bir class gerekiyor.
            //metodu değiştirdim.
            manager.Add(student);

            manager.Add(new Costumer { Id = 1, FirstName = "Engin", LastName = "Demirog", Address = "Ankara" });

            CostumerManager customerManager = new CostumerManager();
            customerManager.Add(new OracleCustomerDal()); //Oracle entegre ettik.
            //Polimorphism = Bir nesneyi farklı amaçlarla impelemte edip farklı özellik ve metotlar kullanmak.

            ICustomerDal[] customerDals = new ICustomerDal[3] { 
                new SqlServerCustomerDal(), 
                new OracleCustomerDal(),
                new MysqlCustomerDal() // yeni bir sql entegre ettik.
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            

            
        }
    }

    interface IPerson
    {
        //properties
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Costumer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departman { get; set; }
    }
    
    class PersonManager
    {
        //public void Add(Costumer costumer)  ***-> Tüm classların kullanabileceği ortak(base) bir class değere atanması gerekiyor
        //{
        //    Console.WriteLine(costumer.FirstName);
        //}

        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
