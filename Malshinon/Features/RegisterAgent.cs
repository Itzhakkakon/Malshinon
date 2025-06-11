using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Malshinon.Database.Services;

namespace Malshinon.Features
{
    internal class RegisterAgent
    {
        public static void Start()
        {
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

            AgentServices.AddAgent(name, codeName);
            Console.WriteLine("Agent registered successfully!");
        }

    }
}
