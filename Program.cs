using System;
using System.Collections.Specialized;

namespace Greenriver_Ranch
{

    public class Program
    {
        
        public static void Main(string[] args)
        {
            var VenderOneItems = new Dictionary<string, double>()
            {
                {"Shovel", 5.00},
                {"Tomato Seed Pouch", 0.50}
            };
            var PlayerInv = new Dictionary<string, int>()
            {
                // {Item_name, item_quantity}
            };
            
            int level = 1;
            double bank = 1000.00;
            double cash = 50.00;
            println("Welcome to GreenRiver Ranch, a console based farming game!");
            println("Please Enter Your Characters Name: ");
            string name = read();
            println($"Hello {name}, Let me introduce you to the market vendor sammy");
            println("Sammy: Howdy There fellar, nice to see some new fellars in these parts. Would you like to browse my wares?");
            print("Enter: ");
            string decision = read().ToLower();
            if(decision == "yes" || decision == "y")
            {
                string printString = "";
                foreach(var items in VenderOneItems)
                {
                    printString += $"I sell {items.Key} for ${items.Value}, ";
                }
                println(printString);
            }
            println("Would you like to buy anything?");
            
                    
                
            
            
            
        }
        public static string read()
        {
            return Console.ReadLine();
        }
        public static void print(string message)
        {
            Console.Write(message);
        }
        public static void println(string message)
        {
            Console.WriteLine(message);
        }
    }
}