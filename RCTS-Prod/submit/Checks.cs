using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RCTS_Prod.Models
{
    //DAA Used to interact with the Checks table
    public class Check
    {
        [Key]
        public int CheckID { get; set; }
        public string Account_No { get; set; }
        public int StoreID { get; set; }
        public string Check_PasserID { get; set; }
        public string Check_No { get; set; }
        public DateTime Date_Check_Received { get; set; }
        public double Amount { get; set; }
        public DateTime Date_Payment_Received { get; set; }
        public double Fee_Received { get; set; }

        public virtual Store Store { get; set; }
        public virtual Check_Passer Check_Passer { get; set; }
        public virtual Account Account { get; set; }
        public virtual ICollection<Letter> Letters { get; set; }
    }

    public class BigViewModel
    {
    public Check Check {get; set;}
    public Check_Passer Check_Passer {get; set;}
    }
    //public class CheckDBContext : DbContext
    //{
    //    public CheckDBContext()
    //        : base("DefaultConnection")
    //    {
    //    }
    //    public DbSet<Check> Checks { get; set; }
        
    //}
}