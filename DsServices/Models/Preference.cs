using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DsServices.Models
{
    public class Preference
    {
        [Key]
        public Int32 PreferenceId { get; set; }
        
        public string PreferenceName { get; set; }

        public Int32 Active { get; set; }

    }
}
