using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultParameterAssmnt
{
    class Method
    {
        public int Add(int x, int y = 2)//method is given two int parameters and assigns one a default value
        {
            return x + y;//returns the math operation x + y, if there is no argument passed for y the method will still operate because of it's default value
        }
    }
}
