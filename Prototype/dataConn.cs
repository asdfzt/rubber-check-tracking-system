using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

[Table("Information")]
public class Information
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)] // required for non auto-generated PK
    public int Drivers_License { get; set; }

    public string Name { get; set; }

    public int Check_No { get; set; }

    public int Routing_No { get; set; }

    public string Address { get; set; }

    public int Telephone { get; set; }

    public int Account_No { get; set; }

    public override string ToString()
    {
        return Name + ": " + Check_No.ToString() + " " + Account_No.ToString();
    }
}

class MyContext : DbContext
{
    // Constructor: provides connection string <connStr> to superclass constructor
    public MyContext(string connStr) : base(connStr) { }

    public DbSet<Information> Informations { get; set; }
}

class Program
{
    static void Main()
    {
        /*
        SqlConnection myConnection = new SqlConnection("Data Source=ZACK-PC;Initial Catalog=RCTS;Integrated Security=True;");

        try
        {
            myConnection.Open();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

        SqlCommand myCommand = new SqlCommand();
        myCommand.CommandText = "INSERT INTO Information (Drivers_License, Name) Values (1, 'zack')";
        myCommand.ExecuteNonQuery();
        */
        using (var db = new MyContext("Data Source=ZACK-PC;Initial Catalog=RCTS;Integrated Security=True;"))
        {

            
            
            Console.WriteLine("Were Connected!!!");
            //db.Database.ExecuteSqlCommand("Select FROM Club WHERE ClubNo = 'C5'");
            var info = new Information();
            info.Name = "Zack Taylor";
            info.Check_No = 1222344532;
            info.Address = "1700 Wade Hampton Blvd";
            info.Check_No = 23;
            info.Drivers_License = 234566;
            info.Routing_No = 234234523;
            info.Telephone = 67876432;

            db.Informations.Add(info);
            db.SaveChanges();
            /*
            // Define a LinQ Query
            var query = from c in db.Clubs
                        where c.CBudget > 300 
                        select c;

            // Execute the query
            var results = query.ToList();

            // Display results
            Console.WriteLine("Clubs with a Budget greater than $300:");

            foreach (Club c in results)
                Console.WriteLine(c);
            */

        }
         
    }
}
