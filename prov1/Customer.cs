using System.Collections.Generic;
using System;

namespace prov1
{
    public class Customer
    {
        public string name;

        private int stupidity;
        private int highRate;
        private int lowRate;
        private int goodRate;
        Random Generator = new Random();
        private List<string> names = new List<string> { "Kurt", "Angela", "Berit" };

        public Customer()
        {
            name = names[Generator.Next(names.Count)];
            stupidity = Generator.Next(2);
        }
      
        public int GetStupidity()
        {
            return stupidity;
        }
    }
}
