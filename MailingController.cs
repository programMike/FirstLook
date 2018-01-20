/* Assignemnt 01: First Look
 * Mike Wemigwans
 * 
 * Controller class
 * Designed to return a view to the browser
 * in response to a get request from the browser
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
/* hard code application data storage using Mailing located within the
 * project model directory
 */
using FirstLook.Models;

namespace FirstLook.Controllers
{
    public class MailingController : Controller
    {
        // GET: Mailing
        public ActionResult Index()
        {
            /* define 3 objects of Mailing type and assign string data values
             * to each of the individual objects for the purpose of providing
             * data to be rendered by the view
             */
            Mailing m1 = new Mailing();
            m1.FirstName = "Steve";
            m1.LastName = "Conger";
            m1.Email = "sc@sc.edu";

            Mailing m2 = new Mailing();
            m2.FirstName = "Joe";
            m2.LastName = "Momma";
            m2.Email = "jm@sc.edu";

            Mailing m3 = new Mailing();
            m3.FirstName = "Fred";
            m3.LastName = "Flint";
            m3.Email = "ff@sc.edu";

            List<Mailing> listOfMailings = new List<Mailing>();
            listOfMailings.Add(m1);
            listOfMailings.Add(m2);
            listOfMailings.Add(m3);

            //return the list of mailings for access to the view
            return View(listOfMailings);
        }
    }
}