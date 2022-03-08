using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Please Enter the day of the week");//user is prompted to enter day o the week
            string userInput = Console.ReadLine();//string variable userInput is given the user inputs value



            try//try is made
            {   //variable day with the data type from enum is made
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);//string converted to enum type
                Console.WriteLine("That is a day of the week " + day);//displayed in console
            }
            catch//catch is made
            {
                Console.WriteLine("That's not a valid day of the week");
            }

            Console.ReadLine();
        }
        public enum DaysOfTheWeek//enum is instantiated and given values
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
