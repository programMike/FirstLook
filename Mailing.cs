/* Assignemnt 01: First Look
 * Mike Wemigwans
 * 
 * Data Model class
 * Designed to store mailing data without defined 
 * contructor of string data type for the purpose
 * introduction to MVC
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstLook.Models
{

    public class Mailing
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}