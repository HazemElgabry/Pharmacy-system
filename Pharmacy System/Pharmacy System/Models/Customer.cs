using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pharmacy_System.Models
{
    public class Customer
    {

        public int id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }

        public string user_name { get; set; }
        public string password { get; set; }

        public int phone_number { get; set; }
        public string date_birth { get; set; }
        public string email_address { get; set; }
        public int card_id { get; set; }


    }
}