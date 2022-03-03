using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass num = new MyClass(); //instantiated MyClass 
            Console.WriteLine("Please enter a whole number");//prompts user to give a number to use 
            int x = Convert.ToInt32(Console.ReadLine());// that number is converted and assigned to variable x
            Console.WriteLine("Your number plus five is: " + num.Add5(x));//the method Add5 is used x is passed as the parameter.
            

            Console.WriteLine("\nPlease enter a decimal number");//prompts user to give a number to use 
            Decimal y = Convert.ToDecimal(Console.ReadLine());// that number is converted and assigned to variable y
            Console.WriteLine("Your number plus five is: " + num.Add5(y));//the method Add5 is used x is passed as the parameter.
            

            Console.WriteLine("\nPlease enter another whole number for a final math operation");//prompts user for a number
            string z = Console.ReadLine();//This time the variable is a string data type and the input is not converted before being passed as an argument
            Console.WriteLine("your number plus five is: " + num.Add5(z));//the method first converts the string to integer and then performs the math operation
            Console.ReadLine();
        }
    }
}
