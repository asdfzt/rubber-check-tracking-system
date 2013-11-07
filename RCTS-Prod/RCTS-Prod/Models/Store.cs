using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RCTS_Prod.Models
{
    //DAA Used to interact with the Store table
    public class Store
    {
        public int StoreID { get; set; }
        public string Store_City { get; set; }
        public string Store_State { get; set; }
    }
    public class StoreDBContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
    }
}