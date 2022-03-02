using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {   //public means it's accessible to other parts of the program.
        public Card() //This is a constructor it can assign default values to a class's objects
        {
            Suit = "Spades";
            Face = "Two";
        }
        public string Suit { get; set; }
        public string Face { get; set; }
    }       //Suit and Face are properties assigned to this class
}
