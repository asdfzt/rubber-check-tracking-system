using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace RCTS_Prod.Models
{
    //DAA Used to interact with the Letter_Texts table
    public class Letter_Text
    {
        [Key]
        public int Letter_TextID { get; set; }
        public string Letter_Path { get; set; }

        public virtual ICollection<Letter> Letters { get; set; }
    }

    //public class Letter_TextDBContext : DbContext
    //{
    //    public DbSet<Letter_Text> Letter_Texts { get; set; }
    //}
}