﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Malshinon.Database.Services;

namespace Malshinon.Features
{
    internal class AddText
    {
        public static string Start()
        {
            string Text;
            do
            {
                Console.WriteLine("Enter your message:");
                string text = Console.ReadLine();
                Text = text;
            } while (string.IsNullOrWhiteSpace(Text));
            return Text;
        }
    }
}
