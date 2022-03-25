using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public struct Card
    {   //public means it's accessible to other parts of the program.
       
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        public override string ToString()//overrides the ToString() method to return "Face of Suit"
        {
            return string.Format("{0} of {1} ", Face, Suit);
        }
    }       //Suit and Face are properties of data type enum assigned to this class
    public enum Suit
    {
        Hearts,
        Daimonds,
        Clubs,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
