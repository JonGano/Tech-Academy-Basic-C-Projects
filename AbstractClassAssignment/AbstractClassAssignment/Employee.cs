using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Employee : Person, IQuittable//states that Employee class inherits from the person class
    {
        public int IdNumber { get; set; }
        public override void SayName()//implements inherited abstract method
            {
                Console.WriteLine("Name: " + firstName + " " + lastName);//prints the person properties on the console
            }
        public void Quit()
        {
            IdNumber = 0;
            Console.WriteLine(firstName + " " + lastName + " not active. " + "Employee Id# changed to: " + IdNumber);
        }
        
    }
}
