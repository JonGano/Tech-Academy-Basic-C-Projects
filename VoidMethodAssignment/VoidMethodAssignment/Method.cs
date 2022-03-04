using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    class Method
    {
        public void MyMethod(int x, int y)//method void - doesn't return anything
        {
            x += 5; //math operation that doesn't return or is ever seen by anything
            Console.WriteLine(y);//prints the y variable on the screen
        }
    }
}
