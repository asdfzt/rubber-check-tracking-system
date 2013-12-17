using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RCTS_Prod.Models
{
    //DAA Used to interact with the Check_Passers table
    public class Check_Passer
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Check_PasserID { get; set; }
        [Required]
        public string Last_Name { get; set; }
        [Required]
        public string First_Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone_No { get; set; }

        public virtual ICollection<Check> Checks { get; set; }
    }

    //public class Check_PasserDBContext : DbContext
    //{
    //    public Check_PasserDBContext()
    //        : base("DefaultConnection")
    //    {}
    //    public DbSet<Check_Passer> Check_Passers { get; set; }

    //}
}