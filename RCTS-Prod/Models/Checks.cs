using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;
using System.Data.Linq.Mapping;

namespace RCTS_Prod.Models
{
    //DAA Used to interact with the Checks table

    public class Check
    {
        [Key]
        public int CheckID { get; set; }
        [Required]
        [ForeignKey("Account")]
        public string Account_No { get; set; }
        [Required]
        [ForeignKey("Store")]
        public int StoreID { get; set; }
        [Required]
        [ForeignKey("Check_Passer")]
        public string Check_PasserID { get; set; }
        [Required]
        public string Check_No { get; set; }
        [Required]
        public DateTime Date_Check_Received { get; set; }
        [Required]
        public double Amount { get; set; }

        public DateTime Date_Payment_Received { get; set; }
        public double Fee_Received { get; set; }

        public int Letter_Text_ID { get; set; }
        
        public DateTime Letter_One_Sent { get; set; }
        public DateTime Letter_One_Received { get; set; }
        public DateTime Letter_Two_Sent { get; set; }
        public DateTime Letter_Two_Received { get; set; }
        public DateTime Letter_Three_Sent { get; set; }
        public DateTime Letter_Three_Received { get; set; }

        public virtual Store Store { get; set; }
        public virtual Check_Passer Check_Passer { get; set; }
        public virtual Account Account { get; set; }
        public virtual Letter_Text Letter_Text { get; set; }

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