using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            //considered best practice to wrap instantiated entity objects in using statments so that Db connection is 
            //closed when the program is done
            using (NewsletterEntities1 db = new NewsletterEntities1())//entity framework object
            {         //db has a property called SignUps that represents all the records in our database   

                // var signups = db.SignUps.Where(x => x.Removed == null).ToList();//can do this in EF instead of an SQL query

                var signups = (from c in db.SignUps//<---This reads a lot more like SQL
                               where c.Removed == null  //(Language Integrated Query)
                               select c).ToList();//<---called a linq. Does the same thing as the lambda function above.
                var signupVms = new List<SignUpVM>();//made a list to hold the data being passed to the view model

                foreach (var signup in signups)//iterates through the db collection, collects the properties of each object or in this case each table column
                { //that are being chosen to be displayed on the VM, and adds them to the list as objects in the VM
                    var signupVm = new SignUpVM();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);

                }

                return View(signupVms);
            }
            //line 20 pretty much replaces all the code that is commented out below using EF
            //Note the difference in the amount of code from below and above using entity framework to map db instead of 
            //linking to the database directly
            //string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber from SignUps";
            //List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);

            //    connection.Open();

            //    SqlDataReader reader = command.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        var signup = new NewsletterSignUp();
            //        signup.Id = Convert.ToInt32(reader["Id"]);
            //        signup.FirstName = reader["FirstName"].ToString();
            //        signup.LastName = reader["LastName"].ToString();
            //        signup.EmailAddress = reader["EmailAddress"].ToString();
            //        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
            //        signups.Add(signup);
            //    }
            //}

        }

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities1 db = new NewsletterEntities1())//establishes our db context which automatically creates a 
            {//connection to the database
      //databaseconnection.tableyou'repullingfrom.Find()-method that finds an entity with the given primary key values
                var signup = db.SignUps.Find(Id);
                //once the the colomn is found by its primary key(Id) the "Removed" row on that column is changed from null to 
                signup.Removed = DateTime.Now;//the current time as it's assigned value type is DateTime 
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}