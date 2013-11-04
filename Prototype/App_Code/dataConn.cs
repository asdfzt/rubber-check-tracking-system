using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;



    public class dataConn
    {
        private static string Table = "Information";
        private static SqlConnection myConnection;
        

        public dataConn(string server, string dbName)
        {
            myConnection = new SqlConnection("Data Source=" + server + ";Initial Catalog=" + dbName + ";Integrated Security=True;");

            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public dataConn()
        {
            myConnection = new SqlConnection("Data Source=localhost;Initial Catalog=RCTS;Integrated Security=True;");

            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        //Adds a record of a blank check to the database
        public bool AddRecord(string tbl, string DL, string name, string CheckNo,
            string RoutingNo, string Address, string TelNo, string AcctNo, string date)
        {
            int x = 499;
            try
            {
                string cmdTxt = "INSERT INTO " + tbl + " (Drivers_License, Name, Check_No," +
                    "Routing_No, Address, Telephone, Account_No, Date)" +
                    "VALUES (@Drivers_License, @Name, @Check_No," +
                    "@Routing_No, @Address, @Telephone, @Account_No, @Date)";

                SqlCommand myCommand = new SqlCommand(cmdTxt, myConnection);
                myCommand.Parameters.AddWithValue("@Drivers_License", DL);
                myCommand.Parameters.AddWithValue("@Name", name);
                myCommand.Parameters.AddWithValue("@Check_No", CheckNo);
                myCommand.Parameters.AddWithValue("@Routing_No", RoutingNo);
                myCommand.Parameters.AddWithValue("@Address", Address);
                myCommand.Parameters.AddWithValue("@Telephone", TelNo);
                myCommand.Parameters.AddWithValue("@Account_No", AcctNo);
                myCommand.Parameters.AddWithValue("@Date", date);

                x = myCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool RemoveByAcc_Routing(string tbl, int AcctNo, int RoutingNo)
        {
            try
            {
                string cmdTxt = "DELETE FROM @tbl WHERE Account_No = '@Account_No'" +
                    "AND Routing_No='@Routing_No'";
                SqlCommand myCommand = new SqlCommand(cmdTxt, myConnection);
                myCommand.Parameters.AddWithValue("@tbl", tbl);
                myCommand.Parameters.AddWithValue("@Account_No", AcctNo);
                myCommand.Parameters.AddWithValue("@Routing_No", RoutingNo);
                myCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Connect(string server, string dbName)
        {
            myConnection = new SqlConnection("Data Source=" + server + ";Initial Catalog=" + dbName + ";Integrated Security=True;");

            try
            {
                myConnection.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public string GetTable(){ return Table; }
    }
