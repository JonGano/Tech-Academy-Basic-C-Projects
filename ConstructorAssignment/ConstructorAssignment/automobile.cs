using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class automobile                                                   //: this() - says it's inheriting the constructor attributes from the origional constructor
    {//constructor chain made with a default for one of the parameters. : this(keeping make parameter, keeping model parameter, defaulting year if not specified)
        public automobile(string make, string model) : this(make, model, 1985)
        {
            //left empty because it's using the origional constructor to assemble the object
        }

        public automobile(string make, string model, int year)//class constructor created with 3 parameters
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void ForSale(int speed)//method created to display all object properties
        {
            //Console.WriteLine("For sale! " + Year + " " +  Make + " " +  Model + ". Top speed is " + speed + " mph.");
            Console.WriteLine("For sale! {0} {1} {2}. top speed {3}", Year, Make, Model, speed);
        }
    }
}
