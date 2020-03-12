using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DsServices.Repository;
using Newtonsoft.Json;
using DsServices.Models;

namespace DsServices.Controllers
{
    //[Route("api/[controller]")]
    public class CustomerController
    {
        [HttpGet("api/LoginUser/{username}/{password}")]
        public string GetCustomerByUserName(string username, string password)
        {
            try
            {
                var dbContext = new DsContext();
                var customers = dbContext.Customer.FirstOrDefault(u => u.UserName == username && u.Password == password);
                return JsonConvert.SerializeObject(customers);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        [HttpPost("api/CreateCustomer/{cust}")]
        public string InsertCustomer(Customer cust)
        {
            try
            {
                var dbContext = new DsContext();
                Customer custTbl = new Customer();
                custTbl.CustomerName = cust.CustomerName;
                custTbl.CustomerAddress = cust.CustomerAddress;
                
                custTbl.EmailId = cust.EmailId;
                dbContext.Customer.Add(custTbl);
                dbContext.SaveChanges();
                return "Customer Saved Successfully";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
