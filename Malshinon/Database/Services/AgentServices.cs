using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Malshinon.Database.Services
{
    internal static class AgentServices
    {
        public static bool ExistingSearch(string name, string codName)
        {
            bool exists = false;
            var con = ManagerDb.GetConnection();
            var sql = """
                      SELECT EXISTS (
                      SELECT 1
                      FROM agent
                      WHERE Name = @name 
                      AND CodName = @codName);
                      """;
                
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@codName", codName);
            con.Open();
            object result = cmd.ExecuteScalar();
            exists = Convert.ToBoolean(result);
            con.Close();
            return exists;
        }
        public static int ReturnId(string name, string codName)
        {
            int id = -1;
            var con = ManagerDb.GetConnection();
            var sql = """
                      SELECT Id
                      FROM agents
                      WHERE Name = @name 
                      AND CodName = @codName;
                      """;
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@codName", codName);
            con.Open();
            object result = cmd.ExecuteScalar();
            id = Convert.ToInt32(result);
            con.Close();
            return id;
        }
        public static void AddAgent(string name, string codName)
        {
            var con = ManagerDb.GetConnection();
            var sql = "INSERT INTO agents (Name, CodName) VALUES (@name, @codName)";
            MySqlCommand cmd = new MySqlCommand(sql,con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@codName", codName);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
