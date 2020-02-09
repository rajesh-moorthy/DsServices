using System;
using MySql.Data;
using System.ComponentModel.DataAnnotations;

namespace DsServices.Models
{
    public class AdImage
    {
        [Key]
        public Int32 AdImageId { get; set; }
        
        public byte[] DisplayImage { get; set; }

        public string ImageSize { get; set; }
        
        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }

    }
}
