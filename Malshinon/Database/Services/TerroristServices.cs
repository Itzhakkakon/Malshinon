using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Malshinon.Database.Services
{
    internal static class TerroristServices
    {
        public static void AddTerrorist(string name, string codName)
        {
            var con = ManagerDb.GetConnection();
            var sql = "INSERT INTO terrorist (Name, CodName) VALUES (@name, @codName)";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@codName", codName);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static int ReturnId(string name, string codName)
        {
            int id = -1;
            var con = ManagerDb.GetConnection();
            var sql = """
                      SELECT Id
                      FROM terrorist
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
    }
}
