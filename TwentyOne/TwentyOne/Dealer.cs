using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {//adds a card to the card list hand which is a property of the player class using add() method
            Hand.Add(Deck.Cards.First());//takes a card at index 0 from deck list using the .First() method
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");//prints the face and suit  of the card to the console with the ToString override from cards class
            Deck.Cards.RemoveAt(0);//removes the card at index 0 so that no one else will receive the card in a future deal

        }
    }
}
