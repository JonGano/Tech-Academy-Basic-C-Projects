using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public Player(string name, int beginningBalance)  //constructors go at the top of the class
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)//Does the player have enough money to make their bet?  could also possibly write like: if (balance >= amount && amount > 0) then flip outcomes
            {
                Console.WriteLine("You do not have enough money to make this bet.");
                return false;
            }
            else
            {
                Balance -= amount;//short hand for balance = balance - amount
                return true;
            }
        }

        public static Game operator +(Game game, Player player)//this overloads the + math operator to allow a shorthand of a specific operation
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
