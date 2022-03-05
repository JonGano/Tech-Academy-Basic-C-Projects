using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClassAssignment
{
    public class Employee : Person//: Person - calls on the person class to be a parent class of employee class
    {   //adds a property that is unique to the emplyee class
        public int Id { get; set; }
    }
}
