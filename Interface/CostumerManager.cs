namespace Interface
{
    class CostumerManager 
    {
        public void Add(ICustomerDal customerDal) // oracle mı yoksa sql mi entegre edeceğiz?
        {
            customerDal.Add();
        }
    }
}
