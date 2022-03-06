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
            Employee HomerS = new Employee() { firstName = "Homer", lastName = "Simpson", IdNumber = 742};

            HomerS.SayName(); //calls the abstract method SayName with the employee object
            HomerS.Quit();
            Console.ReadLine();
        }
    }
}
