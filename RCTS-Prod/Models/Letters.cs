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
    //DAA Used to interact with the Letters table
    public class Letter
    {
        public Letter() { }
        public Letter(int letTxtID, int chID, DateTime LetOneSent, DateTime LetOneRec, DateTime LetTwoSent, DateTime LetTwoRec, DateTime LetThreeSent, DateTime LetThreeRec) {
            Letter_Text_ID = letTxtID;
            CheckID = chID;
            Letter_One_Sent = LetOneSent;
            Letter_One_Received = LetOneRec;
            Letter_Two_Sent = LetTwoSent;
            Letter_Two_Received = LetTwoRec;
            Letter_Three_Sent = LetThreeSent;
            Letter_Three_Received = LetThreeRec;
        }

        [Key]
        public int Letter_ID { get; set; }
        
        public int Letter_Text_ID { get; set; }
        public int CheckID { get; set; }
        public DateTime Letter_One_Sent { get; set; }
        public DateTime Letter_One_Received { get; set; }
        public DateTime Letter_Two_Sent { get; set; }
        public DateTime Letter_Two_Received { get; set; }
        public DateTime Letter_Three_Sent { get; set; }
        public DateTime Letter_Three_Received { get; set; }

        public virtual Letter_Text Letter_Text { get; set; }
        public virtual Check Check { get; set; }
    }

    //public class LetterDBContext : DbContext
    //{
    //    public DbSet<Letter> Letters { get; set; }
    //}
}