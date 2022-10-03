﻿using System;
using System.Collections.Generic;
using System.Text;

namespace breakout
{
    class Utility
    {
        public delegate void PrintPlatform(string message);
        public static PrintPlatform Print = PrintConsole;
        public static void PrintConsole (string message)
        {
            Console.WriteLine(message);
        }
    }
}
