using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace Greenriver_Ranch
{
    public class Player
    {
        public string name;
        public double cash, bank;
        public int level;
        public bool created;
        public Dictionary<string, int> playerInv = new Dictionary<string, int>();
        public Player(string name)
        {
            
            if (this.created)
            {
                // leaving space for future save data loading
            }
            else
            {
                this.name = name;
                this.bank = 1000;
                this.cash = 50;
                this.level = 1;
                playerInv.Add("Shovel", 1);
            };
            
        }
    }
    public class Vendor
    {
        public Dictionary<string, double> options = new Dictionary<string, double>();
        
        public void updateItems(int playerLevel)
        {
            if (playerLevel == 1)
            {
                
            }
        }
    }
    public class Program
    {
        
        public static void Main(string[] args)
        {

            var player = new Player("bob");
            /*
             How to index all items from the inv
            string invString = "";
            foreach(string item in player.playerInv.Keys)
            {
                invString += $"{item} ";
            }
            Console.WriteLine($"Name:  {player.name} \nBank:  {player.bank}\nCash:  {player.cash}\nLevel:  {player.level}\nInventory: {invString}");
            */
                    
                
            
            
            
        }
        
    }
}