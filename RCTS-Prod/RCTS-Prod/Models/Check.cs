using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RCTS_Prod.Models
{
    //DAA Used to interact with the Checks table
    public class Check
    {
        public int CheckID { get; set; }
        public string Account_No { get; set; }
        public int Store_ID { get; set; }
        public string Drivers_License { get; set; }
        public string Check_No { get; set; }
        public DateTime Date_Check_Received { get; set; }
        public double Amount { get; set; }
        public DateTime Date_Payment_Received { get; set; }
        public double Fee_Received { get; set; }
        
    }

    public class CheckDBContext : DbContext
    {
        public DbSet<Check> Checks { get; set; }
        
    }
}