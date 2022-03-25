using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;//references library to access classes that were removed from solution and put into Casino library
using Casino.TwentyOne;//references subclasses in casino library
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne
{
    class Program
    {   //the Main method is the entrance point in a console application
        static void Main(string[] args)//if a method is used without first creating an object of that class it has to be marked static
        {
            //DateTime timeOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime timeOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            //TimeSpan ageOfGraduation = timeOfGraduation - timeOfBirth;
            //string text = File.ReadAllText(@"C:\Users\Jon\Documents\Logs\log.txt");

            const string casinoName = "Grand Hotel and Casino";//constants can't be changed once compiled
            //above example of a constant would be good for something that is referenced several times throughout code.

            //below the constant casinoName is used instead of typing out a unique string to refer to the casino's name
            Console.WriteLine("Welcome to the {0}.  Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();//assigns user's string value to variable playername

            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | " + exception.ExceptionType + " | " + exception.ExceptionMessage + " | " + exception.TimeStamp);
                    Console.WriteLine();
                }
                Console.ReadLine();
                return;
            }

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
            //int is shorthand for int32. Tryparse takes a string parameter, and then has an out parameter to assign a value to the method result
                validAnswer = int.TryParse(Console.ReadLine(), out bank);//result sent to the bank var   //tryparse(string, out int var)
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer.Substring(0, 1) == "y")//wanted to try this instead of yes || yeah || yup || ya 
            {       
                Player player = new Player(playerName, bank); //uses the constructor from the Player class. passes in the two arguments collected from the user
                player.Id = Guid.NewGuid();//generates a new guid for player.id guid property
                                           //using streamwriter, called it file,  assigned it new streamwriter object, path of where log is. StrmWrtr arguments are(string path, bool append)
                using (StreamWriter file = new StreamWriter(@"C:\Users\Jon\Documents\Logs\log.txt", true))//streams are unmanaged code, using statement insures that everything 
                {//automatically disposes of resources/cleans up memory once finished. stream is an incoming flow of bytes, used a lot for things where the final size is incertain
                    file.WriteLine(player.Id);//logs playr Id(guid) property
                }
                Game game = new TwentyOneGame();//polymorphism to utilize the player overload method
                game += player;//player class overload method
                player.isActivelyPlaying = true;//bool changes to true
                while (player.isActivelyPlaying && player.Balance > 0)//loop checks for activelyplaying bool and 0 balance 
                {
                    try//wrapped game.Play in a try/catch 
                    {//any exceptions that happen within the play method will be handled
                        game.Play();//play method is ran. play method is within the twentyOneGame class
                    }
                    catch (FraudException ex)//this is more specific that just (Exception) so it goes first as exceptions are done in order
                    {//gave catch the dataType:fraudexception. To pass in as argument we then give the object a name (ex)
                        Console.WriteLine(ex.Message);//message is written in the play method. only have to change it in one place
                        UpdateDbWithException(ex);//calls on the method created below the main method.
                        Console.ReadLine();
                        return;//ends method
                    }
                    catch (Exception ex)//(Exception) = generic to catch any and all exceptions
                    {//this is the catch all bucket. All other more specific Exceptions inherit from this. it's an example of polymorphism
                        Console.WriteLine("An error occurred. Please contact your System Administrator");
                        //if any exception comes up this string will display in the console
                        UpdateDbWithException(ex);//calls on the method created below the main method.
                        Console.ReadLine();
                        return;//if you type return in a void method(void methods return nothing) it ends the method.
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }
        //Sets exception as parameter. simply writing Exception generically as parameter covers all exceptions. An example of polymorphism.
        private static void UpdateDbWithException(Exception ex)                            //as it is the base class
        {//void method- meaning it doesn't return anything. a lot of times you want it to though to confirm the Db did actually update.
            //always need a connection string to connect to a Db in this manner. which is a long string that usually contains info about
            //the Db instance you're trying to connnect to. A lot of times a username, password, location, where it is, how to access it.
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";

            //this is an actual SQL query.                         //called parameterized queries
            string querystring = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                                (@ExceptionType, @ExceptionMessage, @TimeStamp)";//These values going to be coming in as variables
                                               //putting in a placeholders instead of values.           //you don't want to simply take what a user gives you and plug it 
                                                                                                        //into the query, it opens the door for SQL injection attacks
           //if you go to outside of common language runtime                                            //if a user types drop database instead of their first name for example
           //of the .NET framework to pull something from another program
          //you're opening up resources that could use up a lot of memory and other things
          //"using" is a way of controlling unmanaged resources by assuring the resources are closed once the program is done with them
            using (SqlConnection connection = new SqlConnection(connectionString))
            {//using statment here is entirely different from the ones at the top of the page.
                //SqlCommand is a specific datatype
                SqlCommand command = new SqlCommand(querystring, connection);//passes in the two variables instatiated above

                //adds sql datatype to value being passed into the column specified by the placeholder made from the sql query above 
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);//by naming it's datatype your protecting against sql injection.
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);//added parameter data types
                //You can tell by the add() method that parameters is a list

                //below webstill need to add value to the 3 parameters from above
                //GetType() is a method that gets you the datatype of what you're working with. in this case it's the
                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();//object ex made at the beginning
                //above references the parameters collection element[exceptiontype]  
                command.Parameters["@ExceptionMessage"].Value = ex.Message;//already a string
                //.value is a property of the parameters/the value of it
                command.Parameters["@TimeStamp"].Value = DateTime.Now;//generates the current datetime at any point called on it

                connection.Open(); //info sent to the Db by opening the connection

                command.ExecuteNonQuery(); //query would be a select stament. This here is an insert statement so it is 
                                               //a non query 
                connection.Close();
            }

        }
        private static List<ExceptionEntity> ReadExceptions()
        {//sometimes in larger files you won't have a connection string like this. It will be in a configuration file
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";
            //talks to SQL 
            string querystring = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();//list is made outside of using statment. everything inside statment is is local to it.
            //using controls the stop and start of info from another program outside the .Net Framwork 
            using (SqlConnection connection = new SqlConnection(connectionString))//passes the connectionstring to connection object of SqlConnection class
            {//SqlConnection class instantiates object connect.  passes the querystring to sql from parameter and the object connection as the other
                SqlCommand command = new SqlCommand(querystring, connection);//basically saying I want to communicate with SQL 
                                                                             //SqlCommand represents transaction or stored procedure      //and this is what I want to communicate to it.
                connection.Open();
                //SqlDataReader class object used to read a forward only stream of data
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())//SqlDataReader object "reader" executes the Read() function
                {
                    ExceptionEntity exception = new ExceptionEntity();//creates one list item with 4 properties
                    //this converts the data read from SQL to c# datatypes
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);//adds list item to Exceptions list
                }
                connection.Close();
            }
            return Exceptions;//this function returns a list of Exception entities
        }//there are other ways to access a Db (like frameworks) that can slow things down, but involve less typing and might be a little less in depth
        //but this is a very fast way to access a Db through c#
    }
}
