using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }

        public override void Play()
        {
            Dealer = new TwentyOneDealer();//creates a dealer object
            foreach ( Player player in Players)
            {
                player.Hand = new List<Card>();//creates a new list for the players to hold thier cards
                player.Stay = false;//bool stay false so the player can be dealt a card

            }
            Dealer.Hand = new List<Card>();//new list created for the dealer to hold their cards
            Dealer.Stay = false;//so they can be dealt a card
            Dealer.Deck = new Deck();//so the deck isn't the same deck as before and won't compromise the randomness of the dealings
            Console.WriteLine("Place your bet!");

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine()); //int bet holds the amount the player bets
                bool successfullyBet = player.Bet(bet);//calls the Bet method from the player class
                if (!successfullyBet)//shorthand for if (successfullyBet == false)
                {
                    return;//void methods don't return anything
                } //this return keyword is used to end the method. Because activelyPlaying is still true it starts from the beggining of the while loop again
                Bets[player] = bet; // Bets- is the dictionary created in Game, [player] is the key. and bet is the int amount
            }
            for (int i = 0; i < 2; i++)
            //this counter loop deals a player a hand
            {
                Console.WriteLine("Dealing...");
                foreach ( Player player in Players)
                {
                    Console.Write("{0}: ", player.Name); //what comes after console.Write(instead of console.WriteLine) stays on the same line.
                    Dealer.Deal(player.Hand);
                    if ( i == 1)
                    {                   //must preface s static method with the class name
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);//bool uses TwentyOneRules-CFBJ method to check for blackjack
                        if (blackJack)//if true
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);//adds the bet amount and the winnings to the winners balance
                            return;
                        }
                    }
                }
                Console.WriteLine("Dealer: ");//the process from above with the player is repeated below with the dealer
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);//Checks for BlackJack
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;//the bet amount from all players is turned over to the dealer

                        }
                    }
                }
            }
            foreach (Player player in Players)//iterates through the player list 
            {
                while (!player.Stay)//while loop for players to hit or stay
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0}", card.ToString());//Tostring() is overridden in card class to return "{Face} of {Suit}"
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer.Substring(0, 1) == "s")//if first letter of variable-answer is s
                    {
                        player.Stay = true;
                        break;//breaks from the loop
                    }
                    else if (answer.Substring(0, 1) == "h")//if first letter of string variable answer is h
                    {
                        Dealer.Deal(player.Hand);//runs the Deal() method from dealer class
                    }                                            //passes the players Hand card list as an argument
                    bool busted = TwentyOneRules.IsBusted(player.Hand);//runs the IsBusted method from the TwentyOneRules class
                    if (busted)//if busted == true (is over 21) determined by the IsBusted method
                    {
                        Dealer.Balance += Bets[player];//sends the players bet amount to the dealer never to be seen or heard from again
                        Console.WriteLine("{0} busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                                        //{0} player.name {1}Bets[player]-references person key from Bets dictionary in game class {2}-player.Balance 
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();//ToLower makes sure the string is in lower case to simplify the if statment
                        if (answer.Substring(0, 1) == "y")//looks for a response starting with y
                        {
                            player.isActivelyPlaying = true;//bool isActivelyPlaying remains true
                        }
                        else
                        {
                            player.isActivelyPlaying = false;//stops the while loop in the main program and the game ends
                        }
                    }
                }
            }
            //isBusted method from 21rules class determines if dealer busted
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);//method from 21rules class to determine if dealer needs to stay or hit
            while (!Dealer.Stay && !Dealer.isBusted)//while dealer needs to hit and hasn't gone over 21
            {
                Console.WriteLine("Dealer is hitting");
                Dealer.Deal(Dealer.Hand);//Deal method from dealers class
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); //these two methods check again
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);//for busting or if dealer needs to hit again
            }
            if (Dealer.Stay)//if not the dealer stays
            {
                Console.WriteLine("Dealer is staying");
            }
            if (Dealer.isBusted)//or bust
            {
                Console.WriteLine("Dealer Busted!");
               foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);//finds the name of the player in the KVPair. Pulls from the list,
                   //where() produces a list           //adds to the value the amount bet * 2. to replace the money put up for bet and to compensate
                    Dealer.Balance -= entry.Value;//takes the bet amount the player made and gives it to the winning player
                }
                return;

                //foreach (Player player in Players)                //would this have worked also?
                //{                                                 
                //    if (player.isActivelyPlaying)                //would this have worked also?
                //    {
                //        player.Balance += Bets[player] * 2;           //would this have worked also?
                //    }                    
                //}
            }
            foreach (Player player in Players)
            {//bool? = nullable bool(true, false, null)
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);//runs compareHands method in 21rules class
                if (playerWon == null)//if player tied with the dealer
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];//players bet money is given back to the balance
                }
                else if (playerWon == true)//if player wins
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2); //player is given back the bet amount and their winnings
                    Dealer.Balance -= Bets[player];//players winnings is taken away from the dealer balance
                }
                else//if dealer wins
                {
                    Console.WriteLine("Dealer wins {0}", Bets[player]);
                    Dealer.Balance += Bets[player];//players bet amount is put in dealer balance
                }
                    Console.WriteLine("Play again?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "yes" || answer == "yeah")
                    {
                        player.isActivelyPlaying = true;//while loop continues to run the play() method
                    }
                    else
                    {
                        player.isActivelyPlaying = false;//while loop ends
                    }     
            }  
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
