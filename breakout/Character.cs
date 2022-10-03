using System;
using System.Collections.Generic;
using System.Text;
using static breakout.Utility;

namespace breakout
{
    public class Character
    {
        public string CommonName = "Character";



        public void Action()
        {
            Print($"{CommonName}moves in...");
        }
    }
}
