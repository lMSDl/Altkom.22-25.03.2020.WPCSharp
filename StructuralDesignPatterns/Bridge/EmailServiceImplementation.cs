﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Bridge
{
    class EmailServiceImplementation : IMessageServiceImplementation
    {
        public const int MaxLengh = 10;

        public void SendMessage(string message)
        {
                Console.WriteLine("Email: " + message);
        }
    }
}
