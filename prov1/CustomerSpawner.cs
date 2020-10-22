using System;
using System.Collections.Generic;
namespace prov1
{
    public class CustomerSpawner
    {
        Random Generator = new Random();

        private List<Customer> customers = new List<Customer>();
        public List<Customer> MakeCustomers(){
            customers.Clear();//clears the list so a every day starts with an empty list
            for (int i = 0; i < Generator.Next(3); i++)
            {
                customers.Add(new Customer());  //adds customers into a list 
            }
            return customers;   //returns the list of customers to be used by the game
        }
    }
}
