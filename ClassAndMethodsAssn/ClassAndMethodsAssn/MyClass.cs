using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsAssn
{
    public class MyClass
    {
        public void MyMethod(int x)//void method is made
        {
            x /= 2; //math operation and assignment of x
            Console.WriteLine(x);//This prints the result of the math operation to the console
            
        }
       
        public void MyMethod(double x)//overload using a double data type
        {
            x /= 2;//math operation/ x assignment
            Console.WriteLine(x);//only way that I know of for the outcome of the math operation to get to the console
                                                //in a void method without using an out parameter.
        }
    }
    
}
