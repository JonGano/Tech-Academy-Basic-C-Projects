using System;
using System.Collections.Generic;





class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<int> divlist = new List<int>() { 20, 30, 50, 90, 150, 64, 10, 100, 78 };

            Console.WriteLine("Please enter a number to divide each list integer by");
            int div = Convert.ToInt32(Console.ReadLine());

            foreach (int num in divlist)
            {
                Console.WriteLine(num / div);
            }
            Console.ReadLine();
        }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("this displays outside of the try catch blocks");
            Console.ReadLine();
        }
    }

