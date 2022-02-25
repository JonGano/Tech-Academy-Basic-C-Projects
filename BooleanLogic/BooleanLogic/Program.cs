using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(true && false);//15
            //Console.WriteLine(true && true);//14
            //Console.WriteLine(false && false);//13
            //Console.WriteLine(true || true);//12
            //Console.WriteLine(true || false);//11
            //Console.WriteLine(false || false);//10
            //Console.WriteLine(true == true);//9
            //Console.WriteLine(true == false);//8
            //Console.WriteLine(false == false);//7
            //Console.WriteLine(true != true);//6
            //Console.WriteLine(true != false);//5
            //Console.WriteLine(false != false);//4
            //Console.WriteLine(true ^ true);//3
            //Console.WriteLine(true ^ false);//2
            //Console.WriteLine(false ^ false);//1
            string name = "jon";
            if (name == "dodge")
            {
                Console.WriteLine("hi dodge!");
            } else if (name == "krammer")
            {
                Console.WriteLine("Hi krammer!");
            } else if (name == "joe")
            {
                Console.WriteLine("Hi joe!");
            } else
            {
                Console.WriteLine("HOW DARE YOUR NAME NOT BE DODGE, KRAMMER OR JOE!");
            }
            Console.ReadLine();

        }
    }
}
