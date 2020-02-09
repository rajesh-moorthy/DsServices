using System;
using MySql.Data;
using System.ComponentModel.DataAnnotations;

namespace DsServices.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId {get;set;}
        public string CustomerName {get;set;}
        public int CustomerTown	{get;set;}
        public string EmailId	{get;set;}
        public string MobileNumber {get;set;}
        public string UserName	{get;set;}
        public string Password	{get;set;}
        public string Preferences	{get;set;}
        public int TotalPoints	{get;set;}
        public int PointsRedeemed	{get;set;}
        public DateTime LastLogin	 {get;set;}

    }
}