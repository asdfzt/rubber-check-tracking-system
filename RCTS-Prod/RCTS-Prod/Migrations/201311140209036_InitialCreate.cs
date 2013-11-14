namespace RCTS_Prod.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Checks",
                c => new
                    {
                        CheckID = c.Int(nullable: false, identity: true),
                        Account_No = c.String(maxLength: 128),
                        StoreID = c.Int(nullable: false),
                        Check_PasserID = c.String(),
                        Check_No = c.String(),
                        Date_Check_Received = c.DateTime(nullable: false),
                        Amount = c.Double(nullable: false),
                        Date_Payment_Received = c.DateTime(nullable: false),
                        Fee_Received = c.Double(nullable: false),
                        Check_Passer_Check_PasserID = c.Int(),
                    })
                .PrimaryKey(t => t.CheckID)
                .ForeignKey("dbo.Stores", t => t.StoreID, cascadeDelete: true)
                .ForeignKey("dbo.Check_Passer", t => t.Check_Passer_Check_PasserID)
                .ForeignKey("dbo.Accounts", t => t.Account_No)
                .Index(t => t.StoreID)
                .Index(t => t.Check_Passer_Check_PasserID)
                .Index(t => t.Account_No);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        StoreID = c.Int(nullable: false, identity: true),
                        Store_City = c.String(),
                        Store_State = c.String(),
                    })
                .PrimaryKey(t => t.StoreID);
            
            CreateTable(
                "dbo.Check_Passer",
                c => new
                    {
                        Check_PasserID = c.Int(nullable: false),
                        Last_Name = c.String(),
                        First_Name = c.String(),
                        Street = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        Phone_No = c.String(),
                    })
                .PrimaryKey(t => t.Check_PasserID);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Account_No = c.String(nullable: false, maxLength: 128),
                        Routing_No = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Account_No)
                .ForeignKey("dbo.Banks", t => t.Routing_No)
                .Index(t => t.Routing_No);
            
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        Routing_No = c.String(nullable: false, maxLength: 128),
                        Bank_Phone_No = c.String(),
                        Bank_Street = c.String(),
                        Bank_City = c.String(),
                        Bank_State = c.String(),
                        Bank_Zip = c.String(),
                    })
                .PrimaryKey(t => t.Routing_No);
            
            CreateTable(
                "dbo.Letters",
                c => new
                    {
                        Letter_ID = c.Int(nullable: false, identity: true),
                        Letter_Text_ID = c.Int(nullable: false),
                        Check_ID = c.Int(nullable: false),
                        Letter_One_Sent = c.DateTime(nullable: false),
                        Letter_One_Received = c.DateTime(nullable: false),
                        Letter_Two_Sent = c.DateTime(nullable: false),
                        Letter_Two_Received = c.DateTime(nullable: false),
                        Letter_Three_Sent = c.DateTime(nullable: false),
                        Letter_Three_Received = c.DateTime(nullable: false),
                        Letter_Text_Letter_TextID = c.Int(),
                        Check_CheckID = c.Int(),
                    })
                .PrimaryKey(t => t.Letter_ID)
                .ForeignKey("dbo.Letter_Text", t => t.Letter_Text_Letter_TextID)
                .ForeignKey("dbo.Checks", t => t.Check_CheckID)
                .Index(t => t.Letter_Text_Letter_TextID)
                .Index(t => t.Check_CheckID);
            
            CreateTable(
                "dbo.Letter_Text",
                c => new
                    {
                        Letter_TextID = c.Int(nullable: false, identity: true),
                        Letter_Path = c.String(),
                    })
                .PrimaryKey(t => t.Letter_TextID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Letters", new[] { "Check_CheckID" });
            DropIndex("dbo.Letters", new[] { "Letter_Text_Letter_TextID" });
            DropIndex("dbo.Accounts", new[] { "Routing_No" });
            DropIndex("dbo.Checks", new[] { "Account_No" });
            DropIndex("dbo.Checks", new[] { "Check_Passer_Check_PasserID" });
            DropIndex("dbo.Checks", new[] { "StoreID" });
            DropForeignKey("dbo.Letters", "Check_CheckID", "dbo.Checks");
            DropForeignKey("dbo.Letters", "Letter_Text_Letter_TextID", "dbo.Letter_Text");
            DropForeignKey("dbo.Accounts", "Routing_No", "dbo.Banks");
            DropForeignKey("dbo.Checks", "Account_No", "dbo.Accounts");
            DropForeignKey("dbo.Checks", "Check_Passer_Check_PasserID", "dbo.Check_Passer");
            DropForeignKey("dbo.Checks", "StoreID", "dbo.Stores");
            DropTable("dbo.Letter_Text");
            DropTable("dbo.Letters");
            DropTable("dbo.Banks");
            DropTable("dbo.Accounts");
            DropTable("dbo.Check_Passer");
            DropTable("dbo.Stores");
            DropTable("dbo.Checks");
        }
    }
}
