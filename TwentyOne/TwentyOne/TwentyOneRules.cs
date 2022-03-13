using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules
    {//private because it will only be accessed inside of the TwentyOneRules class              //Dictionary key value pairs here is Face and int
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>() // _ at beginning is a naming convention in private classes 
        { //static so that you don't have to create a 21Rules object to access the functions
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        }; //note the semicolon at the end here. Apparently syntax requires it for dictionaries

        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);//Lambda expression to count how many aces are in a hand
            int[] result = new int[aceCount + 1];//new array consisting of possible results of ace's values. # of Unique results will always be number of ace's + 1 
            int value = Hand.Sum(x => _cardValues[x.Face]);//Takes each face value, looks it up in the dictionary and .sum() gets the total of the int values assigned to it
            result[0] = value;//If there are no ace's, this will be the only possible value / result-array element
            if (result.Length == 1) return result;//Don't have to use curly braces on if statments if it's just one line
            //Nothing else gets executed if the if statment is true and "return result;" is ran.
            for (int i = 1; i < result.Length; i++)
            {   //value = value + (i * 10)
                value += i * 10; //one from the ace is already added in the first value result element leaving-
                result[i] = value;//second possible result added to array.                            //--additional ten to be added to the second result
            }
            return result;
        }

        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();//Lambda max() checks for maximum value
            if (value == 21) return true;
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)//bool method that checks to see if player's hand exceeds twenty one
        {
            int value = GetAllPossibleHandValues(Hand).Min();//.Min() gets the minimum value from the list of possible values
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);//creates an array possibleHandValues by using the GetAllPossibleValue method
                                                                //and passing in the card hand to be evaluated
            foreach (int value in possibleHandValues)//looks through the values array
            {
                if (value > 16 && value < 22) return true;//if statement determines whether or not to stay or hit

            }
            return false;
        }
        //the ? at the end of bool makes it a nullable bool. making a 3rd bool outcome possible(for ties)
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)//method to determines who wins if no one has busted or hit BlackJack
        {                   //this code is short and neat bacause of the use of lambda expressions
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);//creates int array list for player results
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);//creates int array list for dealer results

            int playerScore = playerResults.Where(x => x < 22).Max();//lambda expressions pulls all results under 21 for player and dealer
            int dealerScore = dealerResults.Where(x => x < 22).Max();//.max() finds the highest values for both and assigns them to playerscore and dealerscore

            if (playerScore > dealerScore) return true;//if player wins return true
            else if (playerScore < dealerScore) return false;//if dealer wins return false
            else return null;//if it's a tie return null

            //List<int> bestResult = new List<int>();    // I beleive this would also work but not as clean and a bit more code
            //List<int> DealersBest = new List<int>();     //to accomplish the same results without the use of lambda expressions
            //foreach (int result in playerResults)
            //{
            //    if (result > 22) bestResult.Add(result);
            //}

            //foreach (int result in dealerResults)
            //{
            //    if (result > 22) DealersBest.Add(result);
            //}
            //if (DealersBest.Max() < bestResult.Max()) return true;
            //else if (dealerResults.Max() < bestResult.Max()) return false;
            //else return null;
        }

        }
    }               
