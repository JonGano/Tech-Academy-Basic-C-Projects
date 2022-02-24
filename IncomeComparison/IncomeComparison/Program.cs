using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {   //displays title then prompts user to enter data for person 1
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter hours worked weekly");
            // assigns data to weeklystr and hrlyStr variables from user input
            string person1weeklyStr = Console.ReadLine();
            Console.WriteLine("Please enter hourly rate");
            string person1hrlyStr = Console.ReadLine();

            //executes the same process again prompting user to enter data for person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter hours worked weekly");
            string person2weeklyStr = Console.ReadLine();
            Console.WriteLine("Please enter hourly rate");
            string person2hrlyStr = Console.ReadLine();

            //converts string data into decimal data and assigns the data to variables hrly and weekly
            decimal person1weekly = Convert.ToDecimal(person1weeklyStr);
            decimal person1hrly = Convert.ToDecimal(person1hrlyStr);
            //multiplies the variables together and then by 52 to calculate the annual salary of person 1
            decimal person1Salary = person1hrly * person1weekly * 52;
            //prints annual salary for person1 in the console
            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(person1Salary);
            //converts string data into decimal data and assigns the data to variables hrly and weekly
            decimal person2Weekly = Convert.ToDecimal(person2weeklyStr);
            decimal person2hrly = Convert.ToDecimal(person2hrlyStr);
            //multiplies the variables together and then by 52 to calculate the annual salary of person 2
            decimal person2Salary = person2hrly * person2Weekly * 52;
            //prints annual salary for person2 in the console
            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine(person2Salary);
            // creates a boolean variable to answer the question is person1's salary more than person2's.
            bool SalaryComp = person1Salary > person2Salary;
            //prints the results of the boolean equation in the console and tells user what it is
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(SalaryComp);
            Console.ReadLine();


        }
    }
}
