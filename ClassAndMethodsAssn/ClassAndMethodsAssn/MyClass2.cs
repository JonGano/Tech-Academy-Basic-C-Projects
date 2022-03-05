using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethodsAssn
{
    public static class MyClass2//class declared public and static, cannot be instantiated outside of itself
    {
        public static void MyMethod2(out int y, int x)//out parameter declared
        {
            x /= 2;
            y = x;//allows the resulting value of the equation to exists outside of the method by
                                      //passing it back to a varaible existing in the main program.
        }
    }
}
