using System.Collections.Generic;
using System;

namespace prov1
{
    public class Customer
    {
        public string name;

        private int stupidity;
        private Random Generator = new Random();
        private List<string> names = new List<string> { "Kurt", "Angela", "Berit" };

        public Customer()
        {
            //gives customer a name to be used in future reference
            name = names[Generator.Next(names.Count)];
            //randomnizes stupidity or later display
            stupidity = Generator.Next(2);
        }

        //method that returns stupidity sp it can be read by the game
        public int GetStupidity()
        {
            return stupidity;
        }
    }
}
