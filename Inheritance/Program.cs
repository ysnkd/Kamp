using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaceler tekbaşına anlam ifade etmezken inheritance konusunda classlar ifade eder.
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Engin"},
                new Student{FirstName="Demiroğ"},
                new Person{FirstName="Salih"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string City { get; set; }
    }

    class Student:Person
    {
        public string Departman { get; set; }
    }
    //HER ZAMAN INTERFACE KULLANILIR.GENELLIKLE INTERFACE KULLANMAYA ÇALIŞ
}
