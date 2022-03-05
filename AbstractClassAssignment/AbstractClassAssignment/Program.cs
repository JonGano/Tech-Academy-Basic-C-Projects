using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   //Instantiates an object from the Employee class
            Empoyee HomerS = new Empoyee() { firstName = "Sample", lastName = "Student" };

            HomerS.SayName(); //calls the abstract method SayName with the employee object
            Console.ReadLine();
        }
    }
}
