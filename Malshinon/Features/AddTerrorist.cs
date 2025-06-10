using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Malshinon.Database.Services;

namespace Malshinon.Features
{
    internal class AddTerrorist
    {
        public static int Start()
        {
            string Name;
            string Code;
            do
            {
                Console.WriteLine("Enter name terrorist:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter codename terrorist:");
                string codName = Console.ReadLine();
                TerroristServices.AddTerrorist(name, codName);
                Name = name;
                Code = codName;
            } while (string.IsNullOrWhiteSpace(Name) && string.IsNullOrWhiteSpace(Code));
            return TerroristServices.ReturnId(Name, Code);
        }
    }
}