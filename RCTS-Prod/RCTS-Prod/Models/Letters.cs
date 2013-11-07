using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RCTS_Prod.Models
{
    //DAA Used to interact with the Letters table
    public class Letters
    {
        public int Letter_ID { get; set; }
        public int Letter_Text_ID { get; set; }
        public int Check_ID { get; set; }
        public DateTime Letter_One_Sent { get; set; }
        public DateTime Letter_One_Received { get; set; }
        public DateTime Letter_Two_Sent { get; set; }
        public DateTime Letter_Two_Received { get; set; }
        public DateTime Letter_Three_Sent { get; set; }
        public DateTime Letter_Three_Received { get; set; }
    }

    public class LetterDBContext : DbContext
    {
        public DbSet<Letters> Letters { get; set; }
    }
}