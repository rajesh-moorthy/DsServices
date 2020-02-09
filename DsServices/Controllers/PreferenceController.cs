using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DsServices.Repository;
using Newtonsoft.Json;
using DsServices.Models;


namespace DsServices.Controllers
{
    
    public class PreferenceController : ControllerBase
    {

        [HttpGet("api/GetPreferences")]
        public List<Preference> GetPreference()
        {
            try
            {
                var dbContext = new DsContext();
                var preference = dbContext.Preferences.Where(u => u.Active == 1);
                return preference.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

       
    }
}
