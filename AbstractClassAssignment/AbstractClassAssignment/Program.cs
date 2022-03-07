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
            Employee PhilipJ = new Employee() { firstName = "Philip", lastName = "Fry", IdNumber = 010 };
            IQuittable quit = new Employee();//instantiated an object of type IQuittable using polymorphism 
            HomerS.SayName(); //calls the abstract method SayName with the employee object

            quit.Quit();//used the IQuittable object to run the Quit() method
            Console.WriteLine("Are these employees equal");
            Console.WriteLine(HomerS != PhilipJ);
            Console.ReadLine();
        }
    }
}
