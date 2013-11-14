using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RCTS_Prod.Models
{
    //DAA Used to interact with the Accounts table
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Account_No { get; set; }
        public string Routing_No { get; set; }

        public virtual Bank Bank { get; set; }
        public virtual ICollection<Check> Checks { get; set; }
    }

    //public class AccountDBContext : DbContext
    //{
    //    public DbSet<Accounts> Accounts { get; set; }
    //}
}