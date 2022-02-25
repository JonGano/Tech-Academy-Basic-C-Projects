using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace priceQuote
{
    class Program
    {
        static void Main(string[] args)
        {   //title
            Console.WriteLine("\tWelcome to Package Express.\n    Please follow the instructions below.\n");
            //promts user to enter weight
            Console.WriteLine("what is the wieght(pounds) of your package?");
            //converts string to double and assigns weight value to var weight
            double weight = Convert.ToDouble(Console.ReadLine());
            //conditional statment determines if package exceeds 50 lb weight limit
            if (weight > 50)
            { //if so program stops
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
            }
            else
            { //if not user is prompted for package width and the program continues
                Console.WriteLine("Please enter the package width(inches).");
            }//var width is given the double value of the converted string value
            double width = Convert.ToDouble(Console.ReadLine());
            //var height is given the double value of the converted string value
            Console.WriteLine("Package height?(inches)");
            double height = Convert.ToDouble(Console.ReadLine());
            //var length is given the double value of the converted string value
            Console.WriteLine("Package length?(inches");
            double length = Convert.ToDouble(Console.ReadLine());
            //total variable is made for the following if statment
            double total = width + height + length;
            //if statment determines is the package is too large to be shipped
            if (total > 50)
            { //if so the user is told and the program stops
                Console.WriteLine("Package too big to be shipped via Package Express");
            }
            else
            { // if not the quote based on the weight and dimensions are used to calculate the cost of shipping the package
                double quote = ((width * height * length) * weight) / 100; //then the user is given the cost estimate
                Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
            }

            // this is so the console doesn't dissapear immediately after the last message is printed in the console
            Console.ReadLine();
        }
    }
}
