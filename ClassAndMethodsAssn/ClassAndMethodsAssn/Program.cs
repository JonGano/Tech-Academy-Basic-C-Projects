using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsAssn
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass num = new MyClass();//instantiates an object of the MyClass class
            Console.WriteLine("Please enter a number");//prompts user for a number
            
                int x = Convert.ToInt32(Console.ReadLine());//converts user's input from string to int and assigns to the x variable
            
            Console.WriteLine("Below is a result from a void method math operation");
            num.MyMethod(x);//runs the method from MyClass
            
                int y = 0; //int variable y is created for out parameter argument in mymethod2
            
            MyClass2.MyMethod2(out y, x);//method is called from a static class and can't instatiate an object. Instead that class itself is called to run the method it contains.
            Console.WriteLine("This is the result of an out from a void method math operation\n " + y);//out parameter is displayed on the screen
           
                double z = Convert.ToDouble(y);//varable y is converted to a double and the value is assigned to z variable
            
            Console.WriteLine("This is result of passing the above result through an overload method allowing for double data type");
            num.MyMethod(z);//overload allowing for doulbe arguments is ran.
            
            Console.ReadLine();
        }
    }
}
