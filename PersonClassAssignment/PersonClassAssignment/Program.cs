using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Instantiates an object from the Person Class and gives it's properties values
            Person joe = new Person() { FirstName = "Joe", LastName = "Dimaggio" };
            
            //Instantiates an object from the Employee class and gives it's inherited properties values as well as it's own unique property
            Employee Daniel = new Employee() { FirstName = "Sample", LastName = "Student", Id = 502 };
            
            //calls the method from the Person class on the object joe
            joe.SayName();
            
            //calls the superclass method on the object Daniel from the employee class
            Daniel.SayName();
            Console.ReadLine();


        }
    }
}
