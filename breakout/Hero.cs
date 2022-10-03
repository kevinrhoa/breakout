using System;
using System.Collections.Generic;
using System.Text;
using static breakout.Utility;


namespace breakout
{
    class Hero:  Character, ISave
    {
        
        public void Save()
        {

        }
        
        
        public void Action()
        {
            base.Action();
            Print($"{CommonName} saves the day!");
        }
    }
}
