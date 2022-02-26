using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = "James";
            string mName = "Micheal";
            string lName = "Smith";
            fName = fName.ToUpper();
            mName = mName.ToUpper();
            lName = lName.ToUpper();
            Console.WriteLine("Welcome to our program " + fName + " " + mName + " " +  lName + ".\n Please let us show you to your room.");
            Console.ReadLine();

            StringBuilder paragragh = new StringBuilder();
            paragragh.Append("Now Hiring 200 warehouse workers.");
            paragragh.Append(" No experience necessary.");
            paragragh.Append(" Must have high school diploma or equivalent.\n");
            paragragh.Append("Random drug tests are mandatory.");
            paragragh.Append(" Competative pay,");
            paragragh.Append(" Overtime is mandatory.\n");
            paragragh.Append("Partial benefits after a 90 day probationary period!");
            Console.WriteLine(paragragh);
            Console.ReadLine();
        }
    }
}
