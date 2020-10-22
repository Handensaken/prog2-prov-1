using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;

namespace prov1
{
    public class Book
    {
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        private Random Generator = new Random();

        private List<string> names = new List<string> { "name1", "name2", "name3", "name4", "name5", "name6", "name7" };
        private List<string> categories = new List<string> { "category1", "category2", "category3", "category4", "category5" };

        public Book()
        {
            actualValue = Generator.Next(11, 1001);
            rarity = Generator.Next(1, 6);
            if (Generator.Next(1) == 0) { cursed = false; }
            name = names[Generator.Next(names.Count)];
            category = categories[Generator.Next(categories.Count)];
        }
        public void PrintInfo()
        {
            System.Console.WriteLine($"name: {name}");
            System.Console.WriteLine($"rarity: {rarity}");
            System.Console.WriteLine($"category: {category}");
            System.Console.WriteLine($"price: {price}");
        }
        public int Evaluate()
        {
            double percentage = Generator.Next(50, 150) / 100;
            price = actualValue * rarity;
            return (int)Math.Round(price * percentage);
        }
        public string GetCategory()
        {
            return category;
        }
        public string GetName()
        {
            return name;
        }
        public bool IsCursed()
        {
            if (Generator.Next(6) == 1)
            {
                return !cursed;
            }
            else
            {
                return cursed;
            }
        }



    }
}
