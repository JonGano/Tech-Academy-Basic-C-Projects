using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string brand = "G.M.C."; //creates a constant
            var cartype = "1500";//implicit variable instantiation

            automobile farmTruck = new automobile(brand, cartype);//object created using a constructor call chain
                  //constant and implicit string variable are passed as arguments to the class constructor

            farmTruck.ForSale( 25);//ran class method using farmtruck object
           
            Console.ReadLine();
        }
    }
}
