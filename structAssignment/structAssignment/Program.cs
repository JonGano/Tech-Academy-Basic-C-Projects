using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num;//instantiates num object from the struct type Number

            num.Amount = 42;//assigns 42 vto the amount property of the Number struct object num


            Console.WriteLine(num.Amount);//print the amount property in the console
            Console.ReadLine();
        }
      
    }
}
