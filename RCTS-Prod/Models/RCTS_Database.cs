using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RCTS_Prod.Models
{
    public class RCTS_DatabaseContext : DbContext
    {
        public RCTS_DatabaseContext()
            : base("DefaultConnection")
        {}
        public DbSet<Check> Checks { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Check_Passer> Check_Passers { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Letter_Text> Letter_Texts { get; set; }
        public DbSet<Letter> Letters { get; set; }

    }
}