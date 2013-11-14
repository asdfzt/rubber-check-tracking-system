using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RCTS_Prod.Models
{
    //DAA Used to interact with the Banks table
    public class Bank
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Routing_No { get; set; }
        public string Bank_Phone_No { get; set; }
        public string Bank_Street { get; set; }
        public string Bank_City { get; set; }
        public string Bank_State { get; set; }
        public string Bank_Zip { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }

    //public class BankDBContext : DbContext
    //{
    //    public DbSet<Banks> Banks { get; set; }
    //}
}