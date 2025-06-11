using Malshinon.Database;
using Malshinon.Database.Services;
using Malshinon.Features;
using MySql.Data.MySqlClient;

namespace Malshinon
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string printLogin = "login agent enter 1\n login management enter 2";

            int choice = Utils.GetValidIntegerInput(printLogin, 1, 2);
            if (choice == 1)
            {
                LoginOrRegisterAgent.Start();
            }
            else if (choice == 2)
            {
                ManagementLogin.Start();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            }
        }
    }
}
