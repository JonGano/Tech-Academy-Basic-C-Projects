using System;
using System.Collections.Generic;


namespace ArrayAssignment
{
    class Program
    {
        static void Main()
        {   //creates a string array
            string[] colorArray = { "Red", "Blue", "Grey", "Orange", "Purple", "Green", "Yellow", "Brown" };
            //prompts the user to enter a number then converts the input from string to integer and assigns the value to variable x
            Console.WriteLine("Please enter a number to reveal a color from the color array.");
            int x = Convert.ToInt32(Console.ReadLine());
            //while loop assures that the user can try again if the number is outside of array index 
            while (8 <= x)//so that the program can continue
            {
                Console.WriteLine("Your number was outside the index range.");
                Console.WriteLine("Please enter another number.");
                x = Convert.ToInt32(Console.ReadLine());
            }//after while loop is finished the array element with the index = x will show in the console
            Console.WriteLine(colorArray[x]);
            //integer array is instanciated and assigned values
            int[] intArray = { 22, 47, 34, 55, 87, 1, 93, 76, 52, 8 };
            //prompts user to enter a number and is assigned to Y variable once converted from sting to integer
            Console.WriteLine("Please enter a number to reveal an element from the  array.");
            int Y = Convert.ToInt32(Console.ReadLine());
            //While loop assures the value of Y is within index range
            while (Y > 10)
            {
                Console.WriteLine("Your number was outside the index range.");
                Console.WriteLine("Please enter another number.");
                Y = Convert.ToInt32(Console.ReadLine());
            }//after while loop is done the element with the array index = to Y is shown in the console
            Console.WriteLine(intArray[Y]);
            //string list is created and assigned values
            List<string> strList = new List<string>() { "Take a left", "Take a right", "Go striaight", "Stop", "Merge", "Turn around" };
            //user is prompted to enter a number. that number is converted from string to integer and assigned to the variable z
            Console.WriteLine("Enter a number for driving instructions");
            int z = Convert.ToInt32(Console.ReadLine());
            //while loop assures that variable z is within the range of the list length 
            while (z >= 6)
            {
                Console.WriteLine("Your number was outside the list range");
                Console.WriteLine("Please enter another number.");
                z = Convert.ToInt32(Console.ReadLine());
            }//once the loop is done the list item with the index value = to z is shown on the console and the program ends
            Console.WriteLine(strList[z]);
            Console.ReadLine();
        } 
    }
}
