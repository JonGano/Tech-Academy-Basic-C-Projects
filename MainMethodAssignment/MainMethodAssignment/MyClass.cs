using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class MyClass
    {
        public int Add5(int x)//method to perform a simple math operation using whole numbers
        {
            return x + 5;//returns math operation
        }

        public decimal Add5(decimal x)//overload to allow for decimal numbers
        {
            return x + 5;//returns math operation
        }

        public int Add5(String x)//overload to convert the string automatically
        {
           int y = Convert.ToInt32(x);//first converts string data type to integer and assigns it to the int varaible y

            return y + 5;//returns math operation
        }
    }
    
}
