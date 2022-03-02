using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClassAssignment
{
    public class Class1
    {
        public int Add2(int x)//method Add2 is public so that it can be used and is of integer values
        {                //parameter is stated above a int x
            return x + 2; // math operation is made using the argument pass in by the program
        }

        public int Div2(int x)//2nd method is made in the same way but using division
        {
            return x / 2;
        }
        public int Mul2(int x)//3rd method using multiplication
        {
            return x * 2;
        }//all methods are in the class Class1

    }
}
