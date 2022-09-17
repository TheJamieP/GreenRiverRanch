using System;


namespace Greenriver_Ranch
{
    public class Player
    {
        public string name;
        public double cash, bank;
        public int level;
        public bool created;
        public Dictionary<string, List<string>> playerInv = new Dictionary<string, List<string>>();
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
                playerInv.Add("Shovel", new List<string> { "Shovel", "1", "0" });
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
            // main game
            Console.WriteLine("Welcome to Greenriver Ranch!");
            Console.WriteLine("What is your name?");
            var player = new Player(Console.ReadLine());
            Console.WriteLine("Hello, " + player.name + "!");



        }
        
    }
}