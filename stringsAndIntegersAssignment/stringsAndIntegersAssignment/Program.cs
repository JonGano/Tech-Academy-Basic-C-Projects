using System;
using System.Collections.Generic;





class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<int> divlist = new List<int>() { 20, 30, 50, 90, 150, 64, 10, 100, 78 };
            // a number is promted by the user and assigned to divide the items of the integer list above
            Console.WriteLine("Please enter a number to divide each list integer by");
            //converts user input and assigns integer to variable div
            int div = Convert.ToInt32(Console.ReadLine());
            //foreach executes the division equation on each number of the list
            foreach (int num in divlist)
            {
                Console.WriteLine(num / div);
            }
            Console.ReadLine();
        }
            catch (FormatException ex)//catch if an invalid string is entered that cannot be converted into an integer
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)//catch for an attempt at dividing by zero
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)//catch for too many characters being entered by user
            {
                Console.WriteLine(ex.Message);
            }
            finally //ensures the console can be read if execution is stopped
            {
                Console.ReadLine();
            }
            Console.WriteLine("this displays outside of the try catch blocks");//this prints to the console after all try catch blocks are done executing
            Console.ReadLine();
        }
    }

