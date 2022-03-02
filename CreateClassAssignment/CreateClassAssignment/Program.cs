using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   
            Class1 num = new Class1();//Instantiates an object of Class1. num is then used to carry out the methods below
            Console.WriteLine("Please enter a whole number.");//asks user for a number
            int x = Convert.ToInt32(Console.ReadLine());//Assigns user's number to the variable x

            Console.WriteLine("Here is your number plus two " + num.Add2(x)); //Add2 method is called then displayed in console
            Console.WriteLine("Here is your number multiplied by two " + num.Mul2(x));//Then Mul2 method 
            Console.WriteLine("Here is your number divided by two " + num.Div2(x));//Then Div2
            Console.ReadLine();//So that the user can read the output after the program is done.
        }
        
    }
}
