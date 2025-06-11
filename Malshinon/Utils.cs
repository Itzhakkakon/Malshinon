using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Malshinon
{
    internal class Utils
    {
        public static int GetValidIntegerInput(string prompt, int min, int max)
        {
            int result;
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out result) || result < min || result > max)
            {
                Console.Clear();
                Console.WriteLine($"Invalid input. Please enter a number between {min} and {max}.");
                Console.WriteLine(prompt);
                input = Console.ReadLine();
            }
            return result;
        }
    }
}
