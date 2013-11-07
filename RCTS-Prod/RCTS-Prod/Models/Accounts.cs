using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RCTS_Prod.Models
{
    //DAA Used to interact with the Accounts table
    public class Accounts
    {
        public string Account_No { get; set; }
        public string Routing_No { get; set; }
    }

    public class AccountDBContext : DbContext
    {
        public DbSet<Accounts> Accounts { get; set; }
    }
}