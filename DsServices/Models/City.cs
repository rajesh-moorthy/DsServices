using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DsServices.Models
{
    public class Cities
    {
        [Key]
        public Int32 Id { get; set; }

        public string CountryCode { get; set; }
       
        public string PostalCode { get; set; }

        public string Village { get; set; }
        
        public string State { get; set; }
        
        public string StateID { get; set; }
        
        public string City { get; set; }
        
        public string Town { get; set; }
        
        public string Cord1 { get; set; }
        
        public string Cord2 { get; set; }

        public Int32 Active { get; set; }
    }
}
