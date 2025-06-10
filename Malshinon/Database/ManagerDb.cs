using MySql.Data.MySqlClient;
using System;

namespace Malshinon.Database
{
    public static class ManagerDb
    {
        private static string _userName = "root"; 
        private static string _server = "localhost";  
        private static string _databaseName = "malshinon"; 
        private static string _port = "3306";    
        private static string _password = "";   
        private static string _connectionString = $"user={_userName};Server={_server};Database={_databaseName};port={_port};password={_password}"; // מחרוזת החיבור למסד הנתונים  

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }

    }
}