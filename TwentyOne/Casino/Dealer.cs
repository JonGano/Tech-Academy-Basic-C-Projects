using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {//adds a card to the card list hand which is a property of the player class using add() method
            Hand.Add(Deck.Cards.First());//takes a card at index 0 from deck list using the .First() method
            string card = string.Format(Deck.Cards.First().ToString());
            Console.WriteLine(card + "\n");//prints the face and suit  of the card to the console with the ToString override from cards class           //true means you are wanting to append the file. false would probably create a new file
            //using streamwriter, called it file,  assigned it new streamwriter object, path of where log is. StrmWrtr arguments are(string path, bool append)
            using (StreamWriter file = new StreamWriter(@"C:\Users\Jon\Documents\Logs\log.txt", true))//streams are unmanaged code, using statement insures that everything 
            {//automatically disposes of resources/cleans up memory once finished. stream is an incoming flow of bytes, used a lot for things where the final size is incertain
                file.WriteLine(DateTime.Now);//logs the current date and time for every entry
                file.WriteLine(card);//writes(logs) card string to the file                                
            }
            Deck.Cards.RemoveAt(0);//removes the card at index 0 so that no one else will receive the card in a future deal

        }
    }
}
