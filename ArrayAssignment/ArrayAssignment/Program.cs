using System;
using System.Collections.Generic;


namespace ArrayAssignment
{
    class Program
    {
        static void Main()
        {
            string[] colorArray = { "Red", "Blue", "Grey", "Orange", "Purple", "Green", "Yellow", "Brown" };

            Console.WriteLine("Please enter a number to reveal a color from the color array.");
            int x = Convert.ToInt32(Console.ReadLine());

            while (8 <= x)
            {
                Console.WriteLine("Your number was outside the index range.");
                Console.WriteLine("Please enter another number.");
                x = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(colorArray[x]);

            int[] intArray = { 22, 47, 34, 55, 87, 1, 93, 76, 52, 8 };

            Console.WriteLine("Please enter a number to reveal an element from the  array.");
            int Y = Convert.ToInt32(Console.ReadLine());

            while (Y > 10)
            {
                Console.WriteLine("Your number was outside the index range.");
                Console.WriteLine("Please enter another number.");
                Y = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(intArray[Y]);

            List<string> strList = new List<string>() { "Take a left", "Take a right", "Go striaight", "Stop", "Merge", "Turn around" };
            Console.WriteLine("Enter a number for driving instructions");
            int z = Convert.ToInt32(Console.ReadLine());
            
            while (z >= 6)
            {
                Console.WriteLine("Your number was outside the list range");
                Console.WriteLine("Please enter another number.");
                z = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(strList[z]);
            Console.ReadLine();
        } 
    }
}
