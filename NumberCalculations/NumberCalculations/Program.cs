using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCalculations
{
    class Program
    {
        static void Main(string[] args)
        {   //prompts user for a number and assigns that number to the string variable strNum.
            Console.WriteLine("Please enter any whole number of your choosing to start");
            string strNum = Console.ReadLine();
            // Takes the string variable strNum and converts it to an integer that is assigned to the variable num
            int num = Convert.ToInt32(strNum);                //for the purpose of math operations
            //multiplies the the num variable by 50
            Console.WriteLine(num + " multipied by 50 = " + (num * 50));
            //adds the num variable by 25
            Console.WriteLine(num + " plus 25 = " + (num + 25));
            //divides the num variable by 12.5
            Console.WriteLine(num + " divided by 12.5 = " + (num / 12.5));
            //assigns the bool variable greaterThn to determine if var num is greater than 50
            bool greaterThn = num > 50;
            //expresses to the user the bool greaterThn's outcome
            Console.WriteLine(num + " is greater than 50 is " + greaterThn);
            //shows the remainder of var num / 7 using the modulus operand
            Console.WriteLine(num + " when divided by 7 has a remainder of " + num % 7);
            Console.ReadLine();

        }
    }
}
