using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface ICustomerDal
    {
        //Dal = Veritabanı işlemleri yapılır.
        //interface genellikle veritabanı operasyonları için kullanırız.
        //oracle ve sql olarak iki kalıtım classı

        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            throw new NotImplementedException(); // implement var fakat çalışmıyor.
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
        
    }
    class MysqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Mysql added");
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
