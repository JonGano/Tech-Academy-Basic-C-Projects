using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {   //title is told to show at the beggining of programs run
            Console.WriteLine("\t The Tech Academy \n \tStudent Daily Report");
            Console.WriteLine("\t What is your name?");
                string name = Console.ReadLine();
            //Questions start
            Console.WriteLine("\t What course are you on?");
                string course = Console.ReadLine();//each answer is assigned a variable for future use
            
            Console.WriteLine("\t What page number?");
                string pageNum = Console.ReadLine();
           
            Console.WriteLine("\t Do you need help with anything? Please answer true or false.");
                string help = Console.ReadLine();
           
            bool helpbool = Convert.ToBoolean(help); //string variable help is converted to a boolean and assigned to the boolean  
                                                        //variable helpbool
            Console.WriteLine("\t Were there any positive experiences you'd like to share?");
                string posEx = Console.ReadLine();

            Console.WriteLine("\t Is there any other feedback you'd like to provide? Please be specific.");
                string feedBack = Console.ReadLine();

            Console.WriteLine("\t How many hours did you study today?");
            string hours = Console.ReadLine();
            //after all questions are asked Console.WriteLine() prints a closing statement to the user
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. \nHave a great day!");
            Console.ReadLine(); //console.ReadLine() assures the console doesn't close before the user has a chance to read the last 
            //printed message.
        }
    }
}
