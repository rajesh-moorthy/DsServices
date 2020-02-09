using System;
using MySql.Data;
using System.ComponentModel.DataAnnotations;

namespace DsServices.Models
{
    public class Vendor
    {
        [Key]
        public int VendorId { get; set; }
        
        public string VendorName { get; set; }
        
        public int VendorBusiness { get; set; }

        public string EmailId { get; set; }

        public string MobileNumber { get; set; }
        
        public string UserName { get; set; }
        
        public string Password { get; set; }

        public int TownId { get; set; }

        public int Active { get; set; }

    }
}