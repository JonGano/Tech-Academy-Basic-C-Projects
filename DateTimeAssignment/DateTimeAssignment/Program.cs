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
        {
          
        Console.WriteLine("Please enter a whole number");
            int x = Convert.ToInt32(Console.ReadLine());//took a number from the user's input and gave the vallue to x
           
            //DateTime now = DateTime.Now;//made a dateTime variable with the value of DateTime.Now
            //DateTime variable z is assigned the value of current time + x hours
            DateTime z = DateTime.Now.AddHours(x);//used the .Now method to get the current time value.
             //added hours to the current time by passing the user's number into the AddHours() method as an argument

            Console.WriteLine("it will be {0}, {1} hours from now", z, x);//printed the result to the console
            Console.ReadLine();
        }
    }
}
