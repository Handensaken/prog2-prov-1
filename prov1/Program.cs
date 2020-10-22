using System;
using System.Collections.Generic;
namespace prov1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerSpawner cs = new CustomerSpawner();
            BookSpawner bs = new BookSpawner(); //haha den heter bs
            string[] actions ={"Sell","Don't sell"};
            int balance = 0;
            //etablerear en while loop som loopar tills man väljer att sluta spela
            bool playing = true;
            while (playing)
            {
                List<Customer> customers = cs.MakeCustomers(); //gives new customers every day
                List<Book> books = bs.MakeBook();   //gives new books every day
                System.Console.WriteLine($"you have {customers.Count} customers");
                for (int i = 0; i < books.Count; i++)
                {
                    books[i].PrintInfo();
                }
                for (int i = 0; i < customers.Count;)
                {
                    System.Console.WriteLine($"customer's stupidity is {customers[i].GetStupidity()} and name is {customers[i].name}");
                    if(Selection(actions)==0){
                        balance += Sell(books[i]);
                    }
                    else{
                        System.Console.WriteLine($"sent {customers[i].name} away");
                    }

                    System.Console.WriteLine("for next customer press any key");
                    Console.ReadKey();
                    customers.RemoveAt(0);
                }
                End();
            }
        }
        static int Sell(Book b){
            return b.Evaluate();
        }
        static void End(){
            System.Console.WriteLine("End of the day");
            System.Console.WriteLine("press any button to continue");
            Console.ReadKey(true);
        }
        static void PrintChoices(string[] choices, int current)
        {
            for (int i = 0; i < choices.Length; i++)
            {
                if (current == i)
                {
                    System.Console.WriteLine($"> {choices[i]}");
                }
                else
                {
                    System.Console.WriteLine($"  {choices[i]} ");
                }
            }
        }
        static int Selection(string[] choices)
        {
            int current = 0;
            while (true)
            {
                Console.Clear();
                PrintChoices(choices, current);
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        {
                            current++;
                            current = current % choices.Length;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        {
                            current--;
                            current = Math.Abs(current % choices.Length);
                        }
                        break;
                    case ConsoleKey.Enter:
                        {
                            return current;
                        }
                    default:
                        {
                            // handle everything else
                        }
                        break;
                }
            }
        }
    }
}
