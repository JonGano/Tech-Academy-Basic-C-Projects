using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{               //<T>
    class Employee<T>: Person, IQuittable//states that Employee class inherits from the person class and IQuittable interface
    {
        public List<T> Things { get; set; }
        public int IdNumber { get; set; }
        public override void SayName()//implements inherited abstract method
            {
                Console.WriteLine("Name: " + firstName + " " + lastName);//prints the person properties on the console
            }
        public void Quit()//Implements the IQuittable method
        {
            Console.WriteLine("I quit");
        }
        //public static bool operator== (Employee employee1, Employee employee2) //overloading math operators must always be static
        //{        //overloads the "==" operator to check if there is a duplicate employee I.D. 
        //    return employee2.IdNumber == employee1.IdNumber;//this returns a true or false on the console
        //}
        //public static bool operator!= (Employee employee1, Employee employee2)// bool overloads apparently need to utilize both sides of the coin 
        //{                                                 //making this part involving the "!=" a necessity in order to overload the == bool operator
        //    return employee1.IdNumber != employee2.IdNumber;//this returns a true or false on the console
        //}

        
    }
}
