using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                                                                         //earlier on when setting a class property list 
namespace Casino                        //{ get; set; } is short hand, before it existed, you always had a private list and a publc list like what's below
{                                   //the public list exposed certain ways to access the underlying value of the private list. {get { return _players; }
    public abstract class Game                          //this is the best way to protect your program from adding to a null list. Good habit to have
    {//abstract classes cannot be instantiated                                  //Good practice to do properties of collections like this
        private List<Player> _players = new List<Player>();//lines 11 & 12 are so that there is always an empty list/ list is never null. so that the object can
        public List<Player> Players { get { return _players; } set { _players = value; } }//be instantiated without creating and assigning a list to the object first
        //these two lines above are the exact same thing as a {get; set;} only difference is it is never null unless specified to be.
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
                                                            //(Key Value Pairs)     //value is whatever they're setting it as
        public Dictionary<Player, int> Bets  { get { return _bets; } set { _bets = value; } } //Dictionaries take a key and a value. key is the player and the value is the int amount
       //same thing with dictionary as with player list in regards to {get; set;}
        public string Name { get; set; }

        public abstract void Play();
 

        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
