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
  
    public class VendorController : ControllerBase
    {
        [HttpGet("api/AuthenticateVendor/{username}/{password}")]
        public List<Vendor> AuthenticateVendor(string username, string password)
        {
            try
            {
                var dbContext = new DsContext();
                var vendors = dbContext.Vendors.Where(u => u.UserName == username && u.Password == password);
                return vendors.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        
        [HttpGet("api/GetVendorsByTown/{townId}")]
        public List<Vendor> GetVendorsByTown(int townId)
        {
            try
            {
                var dbContext = new DsContext();
                var vendors = dbContext.Vendors.Where(u => u.Active == 1 && u.TownId==townId);
                return vendors.ToList();
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        // POST: api/TodoItems
        [HttpPost]
        public async Task<ActionResult<Vendor>> PostTodoItem(Vendor vendors)
        {

            var dbContext = new DsContext();
            var vend = dbContext.Vendors.Where(u => u.UserName == vendors.UserName && u.Password == vendors.Password);
            if(vend != null)
            {
                dbContext.Vendors.Add(vendors);
                await dbContext.SaveChangesAsync();
            }
            

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(Vendor), new { id = vendors.VendorId }, vendors);
        }
    }
}