using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age?");
                string agestr = Console.ReadLine();//takes user's input and assigns the value to agestr
                if (agestr.Substring(0, 1) == "0")//determines whether the value starts with a zero
                {
                    throw new ArgumentNullException();//if yes then an exception is thrown
                }
                int age = Convert.ToInt32(agestr);//changes the string var to an int var age
                DateTime current = DateTime.Now;//assigns the current date to var current 

                if (age < 0) throw new ArithmeticException();//determines whether or not age is less than zero
                                                //if yes then an exception is thrown.

                DateTime bDay = current.AddYears(-age);//subtracts the age from the current date
                Console.WriteLine("You were born in " + bDay.Year + " or " + (bDay.Year - 1) + " depending on exaclty when your birthday is.");
                Console.ReadLine();//tells the user around what year they might've been born. just in case they know.
            }
            catch (ArgumentNullException)//this catches the first specific exception that could be thrown
            {
                Console.WriteLine("Age entered cannot start with a zero");
            }
            catch (ArithmeticException)//this catches the second specific exception that could be thrown
            {
                Console.WriteLine("age entered cannot be less than 1.");
            }
            catch (Exception)//any other exception thrown would be caught by the generic exception catch
            {
                Console.WriteLine("Something didn't add up");
            }
            Console.ReadLine();
            //if the code didn't have these two exceptions: the <0 exception or the 01 exception, the program would continue to run. predicting future birthdates
            //and disregarding the zeros at the beggining of a response.
        }
    }
}
