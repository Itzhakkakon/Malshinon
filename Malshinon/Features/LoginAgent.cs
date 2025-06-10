using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Malshinon.Database.Services;

namespace Malshinon.Features
{
    internal class LoginAgent
    {
        public static int Start()
        {
            int id;
            do { 
                string name, codeName;
                do
                {
                    Console.WriteLine("Enter your name:");
                    name = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(name));

                do
                {
                    Console.WriteLine("Enter your codename:");
                    codeName = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(codeName));

                var exists = AgentServices.ExistingSearch(name, codeName);
                if (exists)
                {
                    id = AgentServices.ReturnId(name, codeName);
                }
                else
                {
                    Console.WriteLine("Agent not found, please try again.");
                    id = -1;
                }
            } while (id == -1);
            return id;
        }

    }
}
