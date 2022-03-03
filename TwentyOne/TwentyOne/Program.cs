using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)//if a method is used without first creating an object of that class it has to be marked static
        {
            Deck deck = new Deck();
            int timesShuffled = 0;//added to code to show times shuffled*********
            deck = Shuffle(deck: deck, out timesShuffled, times: 25);//named parameters are not necessary but are easier to read
                                     //added to code to show times shuffled, this is called an "out parameter"*********

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times Shuffled: {0}", timesShuffled);// {} with the number of the variable inside that you want to display {1} would be 
            Console.ReadLine();                                                     //whatever followed timesShuffled, ThisVariable)doesn't exist in this particular code.
        }
                                               //This creates an optional parameter by assigning it a default value
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)// a method must be part of a class
         {
            timesShuffled = 0;//added to code to show times shuffled*********
            for (int i = 0; i < times; i++) //incorporated counter loop code from the overload to produce a smaller amount of code by giving it an optional parameter
            {
                timesShuffled++;//added to code to show times shuffled*********
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            return deck;
        }

        //public static Deck Shuffle(Deck deck, int times) //Creates an overload(method overloading) for the shuffle method. //good for creating a method for api's because default parameters dont always work as well
        //{                     //adds the int times to the parameters
        //    for (int i = 0; i < times; i++)//counter loop used to satisfy the number of times a deck is shuffled
        //    {
        //        deck = Shuffle(deck); //shuffles deck
        //    }
        //    return deck;
        //}
    }
}
