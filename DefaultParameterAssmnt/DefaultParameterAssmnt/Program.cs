using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultParameterAssmnt
{
    class Program
    {
        static void Main(string[] args)
        {
            Method num = new Method(); //instanciates an object named num from the Method class num.(method)() is used to carry out the mehtod

            Console.WriteLine("Please enter a number for my method");//asks user for a number
            int x = Convert.ToInt32(Console.ReadLine());//converts from string to int and assigned to variable x

            Console.WriteLine("Please enter another number for my method if you care to");//gives the user a choice to enter another number
            string q = Console.ReadLine();//that string is assigned to the varable q

            if (q != "")//if the user chooses to enter a second number and the string they enter is not ""(void of characters)
            {
                int y = Convert.ToInt32(q);//string variable q is converted to an integer and assigned to the int varable y
                Console.WriteLine("Your first number and your second number added together are " + num.Add(x, y));//both x and y are passed as arguments to the method
            }
            else  // y is not assigned a value and only one argument from the user passes through the method
            {
                Console.WriteLine("Your number plus two is " + num.Add(x));
            }
            Console.ReadLine();
        }
    }
}

    

