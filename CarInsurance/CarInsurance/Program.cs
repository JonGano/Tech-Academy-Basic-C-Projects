using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {   //title
            Console.WriteLine("\tCar Insurance Application Form\n\n");
            //ask user for driver age then assigns it to agestr variable
            Console.WriteLine("Age of Driver:");
            string agestr = Console.ReadLine();
            //converts agestr variable to int variable age
            int age = Convert.ToInt32(agestr);
            //ask user for a true or false answer and assigns to a string variable
            Console.WriteLine("Have you ever had a DUI?(true/false)");
            string DUIstr = Console.ReadLine();
            //ask user for number of speeding tickes and assigns the value to string variable spdtktstr
            Console.WriteLine("How many speeding tickets do you have?");
            string sptktStr = Console.ReadLine();
            //converts string value to int value and assigns it a spTkt variable
            int spTkt = Convert.ToInt32(sptktStr);
            //converts true or false string value to boolean value and assigns it DUI
            bool DUI = Convert.ToBoolean(DUIstr);
            //Creates a boolean variable that determines whether or not the user input meets the criteria for an auto insurance policy
            bool qualified = age > 15 && DUI == false && spTkt < 4;
            //if/else condition is used to inform the user of whether or not the information provided meets the qualification rules
            if (qualified == true)
            {   //if qualified write this
                Console.WriteLine("Congratulations! You are approved for auto insurance coverage!");
            } else
            {   //if not qualified write this
                Console.WriteLine("Unfortunately you do not qualify for our auto insurance policy at this time.  \nPlease try again in a few months.");
            }
            Console.ReadLine();
           

        }
    }
}
