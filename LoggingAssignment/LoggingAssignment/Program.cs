using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();//asks user for their name and assigns the string to var name
            Console.WriteLine("What's your favorite number?");
            string favNum = Console.ReadLine();//Does the same with user's favorite number
            Console.WriteLine("{0}'s favorite number is {1}", name, favNum);//writes a string on the console
            //below instantiates a StreamWriter object named file, for the purpose of appending a logs file. 
            using (StreamWriter file = new StreamWriter(@"C:\Users\Jon\Documents\Logs\log1.txt", true)) 
            {//"using" insures that needless data is deleted //(file path to the log file,  bool to append file = true) are passed in as the required arguments
                file.WriteLine("{0}'s favorite number is {1}", name, favNum);
            }//file calls on the streamWriter object(file) and using the WriteLine()string is sent to the selected file
            Console.ReadLine();
                


        }
    }
}
