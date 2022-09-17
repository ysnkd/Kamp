using System;

namespace Interfaces2
{
    class Program
    {
        //YAZILIMDA ÇOK ÖNEMLİ BİR PRENSİP VARDIR; YENİ ÖZELLİK EKLENDİĞİNDE MEVCUT KODLARA DOKUNULMAZ!
        //INTERFACE NEWLENEMEZ!
        static void Main(string[] args)
        {
            //Interfaceler referans tiptir. Heapte bir referans id oluşur bellekte.

            IPersonManager customerManager = new CustomerManager(); // customermanager'ın referansı
            
            IPersonManager employeeManager = new EmployeeManager(); // employeemanageri'in referansı

            ProjectManager projectManager = new ProjectManager();
            //projectManager.Add(customerManager);

            projectManager.Add(new InternManager()); //yeni eklediğim özellik

        }
    }
    //interface ile şablon yaratıp istediğiniz kodu yazabilirsiniz.
    // inherits-class ---- implements-interface
    interface IPersonManager
    {
        // public özelliği olmaz sadece void olarak metot olur ve içi boş olur.
        //unimplemented operation
        //başına I harfi getirilir.
        //ayrı implementasyonlar yaratabiliriz
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Musteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("müşteri eklendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("personel eklendi");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("stajyer eklendi");

        }
        public void Update()
        {
            Console.WriteLine("stajyer güncellendi");
        }
    }

        

        class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            
            personManager.Add();
        }

        
    }
}
