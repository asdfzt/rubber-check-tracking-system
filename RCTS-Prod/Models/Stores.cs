using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Data.Entity;

namespace RCTS_Prod.Models
{
    //DAA Used to interact with the Store table
    public class Store
    {
        [Key]
        public int StoreID { get; set; }
        public string Store_City { get; set; }
        public string Store_State { get; set; }

        public virtual ICollection<Check> Checks { get; set; }
    }

    //public class StoreDBContext : DbContext
    //{
    //    public StoreDBContext()
    //        : base("DefaultConnection")
    //    {}
    //    public DbSet<Store> Stores { get; set; }
    //}
}