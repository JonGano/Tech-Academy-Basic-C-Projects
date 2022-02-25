using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoopAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 12;

            do
            {
                age = age + 1;
                Console.WriteLine("Happy Birthday! You are " + age);

                Console.ReadLine();
            }
            while (age < 17);
            Console.WriteLine("Happy Birthday! You're 18 now. Get a job or go to school.");
            Console.ReadLine();
            age = 19;
            while (age < 22)
            {
                Console.WriteLine("Happy birthday! You are " + age + ". get a job or go to school.");
                age = age + 1;
                Console.ReadLine();
            }
            Console.WriteLine("Happy Birthday! You are " + age + ". Where are you going to live now?");
            Console.ReadLine();
        }
    }
}
