using System;
using System.Collections.Generic;
namespace prov1
{
    public class CustomerSpawner
    {
        Random Generator = new Random();

        private List<Customer> customers = new List<Customer>();
        public List<Customer> MakeCustomers(){
            customers.Clear();
            for (int i = 0; i < Generator.Next(3); i++)
            {
                customers.Add(new Customer());
            }
            return customers;
        }
    }
}
