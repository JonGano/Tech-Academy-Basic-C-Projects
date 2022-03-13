using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }                                            //(Key Value Pairs)
        public Dictionary<Player, int> Bets  { get; set; } //Dictionaries take a key and a value. key is the player and the value is the amount

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
