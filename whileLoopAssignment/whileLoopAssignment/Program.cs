using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   //assigns the age variable a value of 12
            int age = 12;
            //
            do //starts a do while statement
            {
                age = age + 1; // adds one to the age variable everytime the loop iterates
                Console.WriteLine("Happy Birthday! You are " + age);
                
                Console.ReadLine();
            } 
            while (age < 17); //do while loop ends once age = 18
            Console.WriteLine("Happy Birthday! You're 18 now. Get a job or go to school.");
            Console.ReadLine();
            age = 19;// age reassigned to show a seamless age progression in the console
            // while statment to count to 22 before the loop ends
            while (age < 22)
            {  
                Console.WriteLine("Happy birthday! You are " + age + ". get a job or go to school.");
                age = age + 1;
                Console.ReadLine();
            }//new message is shown on the screen after the while loop ends and the age is = 22.
            Console.WriteLine("Happy Birthday! You are " + age + ". Where are you going to live now?");
            Console.ReadLine();
        }
    }
}
