using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   //prints the current date and time to the console
            Console.WriteLine("It is currently: " + DateTime.Now + "\n");
        Console.WriteLine("Please enter a whole number");//converted user input to int and
            int x = Convert.ToInt32(Console.ReadLine());//and gave the int value to x
           
            
                 //DateTime variable z is assigned the value of current time + x hours
            DateTime z = DateTime.Now.AddHours(x);      //used the .Now method to get the current time value.
                                    //added hours to the current time by passing the user's number into the AddHours() method as an argument

            Console.WriteLine("It will be {0}, {1} hour(s) from now", z, x);//printed the result to the console
            Console.ReadLine();
        }
    }
}
