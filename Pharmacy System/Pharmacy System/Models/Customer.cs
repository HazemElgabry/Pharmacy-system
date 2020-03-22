using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy_System.Models
{
    public class Customer
    {
        [Key]
        public int customerID { get; set; }
        [Required]
        [MaxLength(50)]
        public string userName { get; set; }
        [MaxLength(50)]
        [Required]
        public string Password { get; set; }
        [MaxLength(50)]
        public string firstName { get; set; }
        [MaxLength(50)]
        public string lastName { get; set; }
        [MaxLength(255)]
        public string address { get; set; }
        public int zipCode { get; set; }
        public int phoneNumber { get; set; }
        [Required]
        [MaxLength(30)]
        public string emailAddress { get; set; }
        public DateTime dateOfBirth { get; set; }
        public int cardID { get; set; }
        public int creditCardNo { get; set; }
        public int cOrderID { get; set; }
    }
}