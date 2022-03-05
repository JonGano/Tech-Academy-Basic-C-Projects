using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Empoyee : Person//states that Employee class inherits from the person class
    {       
        public override void SayName()//implements inherited abstract method
            {
                Console.WriteLine("Name: " + firstName + " " + lastName);//prints the person properties on the console
            }
        
    }
}
