using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino  //below states the parameter you wish to keep //below has the top constructor inherit from the origional constructor with a default value on the second parameter
{                                  //public Player(string name) : this(name, 100) has the constructor
    public class Player
    {   //constructor call chain--reuse of constructors
        public Player(string name) : this(name, 100)//uses existing constructor to make one with a default begginningBalance
        {//so that only one argument is required instead of two
            //nothing needs to be written here because it's already written in the origional constructor below
        }//constructor chaining can be useful when your using a lot of constructors or very long constructors 
        public Player(string name, int beginningBalance)  //constructors go at the top of the class
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        private List<Card> _hand = new List<Card>();          //see game class properties for more in depth explanation
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }//lines 17 & 18 make an empty list instead of null list initially
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public Guid Id { get; set; }
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
