using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        //entity framework is a wrapper for ADO.NET. the interface it provides is very simple. Just add entities
        //to it and it does all the work.
        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {//using statment wraps up the entity, NlE1 is instantiated with the name db.  this object was designed to 
                using (NewsletterEntities1 db = new NewsletterEntities1())//be the link to your db by entity framework.
                {
                    var signup = new SignUp();//This gathers the data from the view and adds to the object SignUp which
                    signup.FirstName = firstName;//is comprised of a list of properties that translate into a full row on
                    signup.LastName = lastName;//the database table that the object was created to inhabit/fill
                    signup.EmailAddress = emailAddress;

                    db.SignUps.Add(signup);//this adds the newly created object to the Db
                    db.SaveChanges();//this saves the changes made to the Db.
                }
                //below is a "manual" link to database without the use of Entity Framework or "EF".
                //as you can see it is a lot more code.  This eay can be usfull if you're looking to speed up a program
                //as a framework can slow things down a little bit.
                //string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES
                //                        (@FirstName, @LastName, @EmailAddress)";

                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = new SqlCommand(queryString, connection);
                //    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                //    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                //    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                //    command.Parameters["@FirstName"].Value = firstName;
                //    command.Parameters["@LastName"].Value = lastName;
                //    command.Parameters["@EmailAddress"].Value = emailAddress;

                //    connection.Open();
                //    command.ExecuteNonQuery();
                //    connection.Close();
                //}
                return View("Success");
            }
        }

    }
}