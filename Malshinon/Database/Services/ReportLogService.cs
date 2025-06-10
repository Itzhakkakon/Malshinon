using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Malshinon.Models;
using MySql.Data.MySqlClient;

namespace Malshinon.Database.Services
{
    internal static class ReportLogService
    {
        public static void AddReportLog(int agentId, int targetId, string allText)
        {
            var con = ManagerDb.GetConnection();
            var sql = "INSERT INTO reportlog (AgentId, TerroristId, ReportText) VALUES (@AgentId, @TerroristId, @ReportText)";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@AgentId", agentId);
            cmd.Parameters.AddWithValue("@TerroristId", targetId);
            cmd.Parameters.AddWithValue("@ReportText", allText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}