using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Method num = new Method();//instanciates an object of the method class named num

            num.MyMethod(3, 4);//called the method and gave it parameters

            num.MyMethod(x: 2, y: 4); //Specified parameters by name in the method

            Console.ReadLine();
         
        }
    }
}
