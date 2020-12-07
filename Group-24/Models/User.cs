using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Group_24.Models
{
    public class User    {

        [Display(Name = "User ID")]
        public int UserID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Mod Level")]
        public int ModLevel { get; set; }

    }
}
