using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RCTS_Prod.Models
{
    //DAA Used to interact with the Banks table
    public class Banks
    {
        public int Routing_No { get; set; }
        public string Bank_Phone_No { get; set; }
        public string Bank_Street { get; set; }
        public string Bank_City { get; set; }
        public string Bank_State { get; set; }
        public string Bank_Zip { get; set; }
    }

    public class BankDBContext : DbContext
    {
        public DbSet<Banks> Banks { get; set; }
    }
}