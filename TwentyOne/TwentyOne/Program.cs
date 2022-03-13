using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {   //the Main method is the entrance point in a console application
        static void Main(string[] args)//if a method is used without first creating an object of that class it has to be marked static
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino.  Let's start by telling me your name.");
            string playerName = Console.ReadLine();//assigns user's string value to variable playername

            Console.WriteLine("And how much money did you bring today?");//assign user's int value to varaible bank
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            
            string answer = Console.ReadLine().ToLower();
            if (answer.Substring(0, 1) == "y")//wanted to try this instead of yes || yeah || yup || ya 
            {       
                Player player = new Player(playerName, bank); //uses the constructor from the Player class. passes in the two arguments collected from the user
                Game game = new TwentyOneGame();//polymorphism to utilize the player overload method
                game += player;//player class overload method
                player.isActivelyPlaying = true;//bool changes to true
                while (player.isActivelyPlaying && player.Balance > 0)//loop checks for activelyplaying bool and 0 balance 
                {
                    game.Play();//play method is ran. play method is within the twentyOneGame class
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }
    }
}
