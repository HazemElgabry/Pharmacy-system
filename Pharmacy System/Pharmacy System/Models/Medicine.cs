using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pharmacy_System.Models
{
    public class Medicine
    {
        public int id { get; set; }
        [Display(Name = "Medicine Name")]
        public string name { get; set; }

        public int Price { get; set; }
        [Display(Name = "Expire Date")]
        public string expire_date { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        [Display(Name = "Import Date")]
        public string import_date { get; set; }
        [Display(Name = "Black List")]
        public string black_list { get; set; }
        [Display(Name = "Max Dose")]
        public string max_dose { get; set; }


    }
}