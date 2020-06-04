using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pharmacy_System.Models
{
    public class News
    {
        public int id { get; set; }

        [Required(ErrorMessage = "* You must enter title")]
        [Display(Name = "Title")]
        public string title { get; set; }

        [Required(ErrorMessage = "* You must enter Image for news")]
        [Display(Name = "Img")]
        public string img { get; set; }


        public string description { get; set; }


        [Required(ErrorMessage = "* You must enter release date for the news")]
        [Display(Name = "Release Date")]
        public DateTime release_date { get; set; }



    }
}