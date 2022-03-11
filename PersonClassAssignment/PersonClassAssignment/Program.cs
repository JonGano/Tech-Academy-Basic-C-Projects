using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClassAssignment
{
    class Program
    {
        public static object FirstName { get; private set; }

        static void Main(string[] args)
        {
            Employee HomerS = new Employee() { FirstName = "Homer", LastName = "Simpson", Id = 742 };
            Employee PhilipJ = new Employee() { FirstName = "Philip", LastName = "Fry", Id = 2000 };
            Employee Generic = new Employee() { FirstName = "Gene", LastName = "Ric", Id = 100 };//instantiates Generic object with string type
            Employee Bender = new Employee() { FirstName = "Bender", LastName = "Rodrigez", Id = 1101101 };
            Employee Morty = new Employee() { FirstName = "Morty", LastName = "Smith", Id = 3137 };
            Employee Louis = new Employee() { FirstName = "Louis", LastName = "Griffin", Id = 1212 };
            Employee Joe1 = new Employee() { FirstName = "Joe", LastName = "Dimaggio", Id = 5 };
            Employee Joe2 = new Employee() { FirstName = "Joe", LastName = "Pesci", Id = 4601 };
            Employee Jean = new Employee() { FirstName = "Jean", LastName = "Gray", Id = 10 };
            Employee Mike = new Employee() { FirstName = "Mike", LastName = "Tyson", Id = 218 };

            List<Employee> employees = new List<Employee>() { Mike, Jean, Joe1, Joe2, Louis, Morty, Bender, Generic, PhilipJ, HomerS };
            List<Employee> JoeList = new List<Employee>();//Instantiates a list for employee objects
            foreach (Employee worker in employees)
            {
                if (worker.FirstName == "Joe")//looks for employee objects with the first name joe
                {
                    JoeList.Add(worker);//adds those objects to the list employees
                }
            }
            for (int i = 0; i < JoeList.Count(); i++)////counter loop to iterate through the new list
            {
                Console.WriteLine(JoeList[i].LastName);//prints out the last name property to the console
            }

            List<Employee> workers = employees.Where(x => x.FirstName == "Joe").ToList();//makes a new list, looks for FirstName properties with the value "Joe"
                                                                                         //from the employees list and adds them to the new list workers
            foreach (Employee worker in workers)
            {
                Console.WriteLine(worker.LastName);
            }
            

            //Instantiates an object from the Person Class and gives it's properties values
            //Person joe = new Person() { FirstName = "Joe", LastName = "Dimaggio" };

            //Instantiates an object from the Employee class and gives it's inherited properties values as well as it's own unique property
            // Employee Daniel = new Employee() { FirstName = "Sample", LastName = "Student", Id = 502 };

            //calls the method from the Person class on the object joe
            //joe.SayName();

            //calls the superclass method on the object Daniel from the employee class
            //Daniel.SayName();
            Console.ReadLine();


        }
    }
}
