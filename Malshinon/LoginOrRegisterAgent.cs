using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Malshinon.Database.Services;
using Malshinon.Features;
using Malshinon.Models;

namespace Malshinon
{
    internal class LoginOrRegisterAgent
    {
        static int idLogin = -1;
        static int idTerrorist = -1;
        static string textReport;
        public static void Start()
        {
            while (idLogin == -1)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Agent Login System");
                Console.WriteLine("Please enter your credentials to login or register.");
                Console.WriteLine("If you are a new agent, please register first.");
                idLogin = LoginOrRegister();
            }

            Console.Clear();
            //Console.WriteLine("Welcome to the Agent System");
            //Console.WriteLine("You are now logged in.");
            //Console.WriteLine("Press any key to continue...");

            //Console.WriteLine()
            while (idTerrorist == -1)
            {
                idTerrorist = AddTerrorist.Start();
            }


            Console.Clear();

            while (string.IsNullOrWhiteSpace(textReport))
            {
                textReport = AddText.Start();
            }

            ReportLogService.AddReportLog(idLogin, idTerrorist, textReport);
            idLogin = -1; // Reset idLogin for next login
            idTerrorist = -1; // Reset idTerrorist for next report
            textReport = string.Empty; // Reset textReport for next report

        }
        private static int LoginOrRegister()
        {
            string printLoginAgent = "Login enter 1\n Register enter 2";
            int choice = Utils.GetValidIntegerInput(printLoginAgent, 1, 2);
            if (choice == 1)
            {
                return LoginAgent.Start();
            }
            else if (choice == 2)
            {
                RegisterAgent.Start();
            }
            return -1;
        }
    }
}
