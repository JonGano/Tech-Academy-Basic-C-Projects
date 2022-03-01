using System;
using System.Collections.Generic;

namespace iterationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = { "Ford ", "Chevy ", "Toyota ", "Dodge ", "GMC ", "Nissan " };
            //input is taken from he user and assigned to the variable add
            Console.WriteLine("What type of vehicle do you prefer: Sedan, Pickup, Van, or SUV?");
            string add = Console.ReadLine();

            Console.WriteLine("\nHere are some brands available for that type of vehicle");
            //this loop iterates through the array and adds the users input to the end of each element of the array 
            for (int i = 0; i < strArray.Length; i++)//Comparison operator for the continued loop is <
            {
                strArray[i] = strArray[i] + add;
                Console.WriteLine(strArray[i]);
            }
            Console.ReadLine();
            int infinite = 10; //loop where the comparison operator to determine whether to continue iterating the loop is <=
            while (infinite <= 10)
            {
                infinite++; //one is added to the variable with each iteration through the while loop, so that the loop will only execute once instead of infinitely.
                Console.WriteLine("\nThis is no longer an infinite loop!");
            }
            Console.ReadLine();                                                    //a second red element to test that the program stops looking once a match is found
            List<string> colorList = new List<string>() { "orange", "blue", "red", "green", "purple", "yellow", "teal", "red" };
            List<string> matchList = new List<string>(); //this list is instatiated to create a conditional statement in the event no match is found
            Console.WriteLine("\n \nSearch to see if you favorite color is on the list");
            string search = Console.ReadLine();
            search = search.ToLower();//changes all user input to lower case before searching for a potential match 

            //looks through the list
            foreach (string color in colorList)
            {   //for this condition
                if (color == search)
                {
                    matchList.Add(color); //adds an element to the matchlist to render the conditional stament below null.
                    Console.WriteLine("This matched your search: " + color);
                    // ------------------------------>   break;// without this break, both indices with the string value red would be shown. <----------------------------------------------------
                }
            }//use .count method to search for a no match scenario. if true, the computer informs the user.
            if (matchList.Count == 0)
            {
                Console.WriteLine("There doesn't seem to be any matches for the color you gave.");
            }
            Console.ReadLine();
            //instantiates a list containing one duplicate for the program to find 
            List<string> sodas = new List<string> { "coke", "pepsi", "rc", "dr. pepper", "mr. pibb", "sprite", "rc" };
            //blank list is instantiated for the purpose of sifting through the elements and finding the duplicate element.
            List<string> matchingDrinks = new List<string>();
            //works through the elements on the first list
            foreach (string soda in sodas)//
            {
                bool check = false;//assigns a boolean variable with the value of false

                foreach ( string match in matchingDrinks)//works through the second list
                {
                    if ( match == soda)//compares match to soda 
                    {
                        check = true;//if equal  boolean check changes to true
                    }
                }
               if ( check == true)//once theres a match it shows the matching list item and informs the user
                {
                    Console.WriteLine(soda + " has already appeared in the list");
                }
               else // if there's no match then the soda list item is added to the matching drink list
                {
                    Console.WriteLine(soda);
                    matchingDrinks.Add(soda);
                }
                
              
                
            }
            Console.ReadLine();
        }
    }
}
