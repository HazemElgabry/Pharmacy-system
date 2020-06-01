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
        public string name { get; set; }

        public int Price { get; set; }
        public string expire_date { get; set; }
        public string description { get; set; }
        public string import_date { get; set; }
        public string black_list { get; set; }
        public string max_dose { get; set; }
        [Required(ErrorMessage = "* Please upload medicine image")]
        public string Image { get; set; }


    }
}