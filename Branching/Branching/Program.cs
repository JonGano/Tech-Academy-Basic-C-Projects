using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //int currentTemp = 70;
            //int roomTemp = 80;


            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("Room temperature is warmer than current temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exaclty room temperature.");
            //}
            //Console.ReadLine();

            //string comparisonResult = currentTemp == roomTemp ? "It is room temp." : "It is not room temp.";
            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();


            //int roomtemp = 70;
            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine());

            //if (currentTemp == roomtemp)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (currentTemp > roomtemp)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomtemp > currentTemp)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("uhhhhhhh... something went wrong");
            //}
            //Console.ReadLine();


            //ternary operation
            Console.WriteLine("What is your favorite number?");
            int favnum = Convert.ToInt32(Console.ReadLine());

            string result = favnum == 12 ? "You have an awsome favorite number!" : "Your favorite number sucks!";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
