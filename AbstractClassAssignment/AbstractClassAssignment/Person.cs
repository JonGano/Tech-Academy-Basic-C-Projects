using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public abstract class Person
    {   //sets properties for the Person class
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void SayName();// instantiates an abstract method named SayName
        
    }
}
