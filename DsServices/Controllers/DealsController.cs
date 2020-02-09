using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DsServices.Repository;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;


namespace DsServices.Controllers
{
    public class DealsController : ControllerBase
    {
        private IConfiguration configuration;

        public DealsController(IConfiguration config)
        {
            configuration = config;
        }
        
        [HttpGet("api/GetCouponCode")]
        public string GenerateOTP(int CustomerId)
        {
            string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string small_alphabets = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "1234567890";

            string characters = alphabets + small_alphabets + numbers;

            int length = int.Parse(configuration.GetValue<string>("MySettings:CouponLength"));
            string otp = string.Empty;
            for (int i = 0; i < length; i++)
            {
                string character = string.Empty;
                do
                {
                    int index = new Random().Next(0, characters.Length);
                    character = characters.ToCharArray()[index].ToString();
                } while (otp.IndexOf(character) != -1);
                otp += character;
            }
            return JsonConvert.SerializeObject(otp);
        }
    }
}