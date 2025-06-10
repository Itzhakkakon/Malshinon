using Malshinon.Database;
using Malshinon.Database.Services;
using MySql.Data.MySqlClient;

namespace Malshinon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Login enter 1\n Register enter 2");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    int agentId = Features.LoginAgent.Start();
                    int targetId = Features.AddTerrorist.Start();
                    string reportText = Features.AddText.Start();
                    ReportLogService.AddReportLog(agentId, targetId, reportText);
                    break;

                case "2":
                    break;
            }
        }
    }
}
