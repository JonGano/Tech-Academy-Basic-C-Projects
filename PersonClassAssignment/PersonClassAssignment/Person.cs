using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClassAssignment
{
    public class Person
    {   //sets a first and last name property
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public void SayName()
        {
            //creates a method inside the person class that outputs the person object's assigned properties to the console
            Console.WriteLine("Name: [" + FirstName + " " + LastName + "]");
        }

    }
}
