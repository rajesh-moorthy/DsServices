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
    
    public class TownController : ControllerBase
    {
        [HttpGet("api/GetTowns")]
        public List<Towns> GetActiveTowns()
        {
            try
            {
                var dbContext = new DsContext();
                var town = dbContext.Town.Where(u => u.Active == 1);
                return town.ToList()
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}