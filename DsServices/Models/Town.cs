using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DsServices.Models
{
    public class Towns
    {
        [Key]
        public Int32 TownId { get; set; }

        public string TownName { get; set; }

        public Int32 Active { get; set; }
    }
}
