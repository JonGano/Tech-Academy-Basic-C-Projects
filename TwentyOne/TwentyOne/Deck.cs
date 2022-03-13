using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {   //Constructors always go at the top before properties
        
        
        public Deck()//constructor method is always the same name as the class that it's in
        {
            Cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }

            //List<string> Suits = new List<string>() { "Clubs", "Hearts", "Daimonds", "Spades" };
            //List<string> Faces = new List<string>() { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

            //foreach (string face in Faces)
            //{
                //foreach (string suit in Suits)
                //{
                //    Card card = new Card();
                //    card.Suit = suit;
                //    card.Face = face;
                //    Cards.Add(card);
                //}
            

            //Cards = new List<Card>(); <------------Manualy setting every individual card
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {          
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
           
        }
       
    }
}
