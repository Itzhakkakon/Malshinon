using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Malshinon.Database.Services;

namespace Malshinon.Features
{
    internal class LoginAgent
    {
        public static int Start()
        {
            string Name;
            string Code;
            while (true)
            {
                Console.WriteLine("Enter your name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your codename:");
                string codName = Console.ReadLine();
                var exists = AgentServices.ExistingSearch(name, codName);
                if (exists)
                {
                    Name = name;
                    Code = codName;
                    break;
                }
                else
                {
                    Console.WriteLine("Agent not found, please try again.");
                }
            }
            return AgentServices.ReturnId(Name, Code);
        }

    }
}
