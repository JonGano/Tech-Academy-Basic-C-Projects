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
            Employee<string> HomerS = new Employee<string>() { firstName = "Homer", lastName = "Simpson", IdNumber = 742};
            Employee<string> PhilipJ = new Employee<string>() { firstName = "Philip", lastName = "Fry", IdNumber = 2000 };
            Employee<string> Generic = new Employee<string>() { firstName = "Gene", lastName = "Ric", IdNumber = 100 };//instantiates Generic object with string type
            Employee<string> Bender = new Employee<string>() { firstName = "Bender", lastName = "Rodrigez", IdNumber = 1101101 };
            Employee<string> Morty = new Employee<string>() { firstName = "Morty", lastName = "Smith", IdNumber = 3137 };
            Employee<string> Louis = new Employee<string>() { firstName = "Louis", lastName = "Griffin", IdNumber = 1212 };
            Employee<string> Joe1 = new Employee<string>() { firstName = "Joe", lastName = "Dimaggio", IdNumber = 5 };
            Employee<string> Joe2 = new Employee<string>() { firstName = "Joe", lastName = "Pesci", IdNumber = 4601 };
            Employee<string> Jean = new Employee<string>() { firstName = "Jean", lastName = "Gray", IdNumber = 10 };
            Employee<string> Mike = new Employee<string>() { firstName = "Mike", lastName = "Tyson", IdNumber = 218 };

            List<Employee<string>> employees = new List<Employee<string>>() { Mike, Jean, Joe1, Joe2, Louis, Morty, Bender, Generic, PhilipJ, HomerS  };
            foreach (Employee worker in employees)

                Employee<int> Generic2 = new Employee<int>();
            Generic.Things = new List<string> { "Tools", "Uniform", "Boots", "Hardhat" };//creates a list  and assigns values to the things property of object generic
            Generic.Things.ForEach(Console.WriteLine); //iterates through the list and prints elements to the console
            Generic2.Things = new List<int> { 2, 3, 5, 7, 8, 9, 10, 37 };
            Generic2.Things.ForEach(Console.WriteLine);//iterates through the list and prints all elements to the console
           IQuittable quit = new Employee();//instantiated an object of type IQuittable using polymorphism 
            HomerS.SayName(); //calls the abstract method SayName with the employee object

            quit.Quit();//used the IQuittable object to run the Quit() method
            //Console.WriteLine("Are these employees equal");
            //Console.WriteLine(HomerS == PhilipJ);//runs the operator overload method
            Console.ReadLine();
        }
    }
}
