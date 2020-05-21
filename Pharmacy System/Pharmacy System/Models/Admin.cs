using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Pharmacy_System.Models
{
    public class Admin
    {


        public int id { get; set; }

        [Required(ErrorMessage = "* You must enter your First name")]
        [Display(Name = "First Name")]
        public string fname { get; set; }

        [Required(ErrorMessage = "* You must enter your Last name")]
        [Display(Name = "Last Name")]
        public string lname { get; set; }

        [Required(ErrorMessage = "* You must enter your User name")]
        [Display(Name = "User Name")]
        public string user_name { get; set; }

        [Required(ErrorMessage = "* You must enter your password")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [Display(Name = "Password")]
        [MembershipPassword(
            MinRequiredNonAlphanumericCharacters = 1,
            MinNonAlphanumericCharactersError = "Your password needs to contain at least one symbol (!, @, #, etc).",
            ErrorMessage = "Your password must be 6 characters long and contain at least one symbol (!, @, #, etc)."
        )]
        public string password { get; set; }


        [Required(ErrorMessage = "* You must enter your Phone Number")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 11)]
        public string phone_number { get; set; }


        public string date_birth { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "* You must enter your password")]
        [RegularExpression(@"\w+([-+.']\w+)@\w+([-.]\w+).\w+([-.]\w+)*", ErrorMessage = "Must be a valid Email Address")]
        public string email_address { get; set; }

        [Range(0, 9999999999999999, ErrorMessage = "* Please enter a valid price")]
        public int card_id { get; set; }



    }
}