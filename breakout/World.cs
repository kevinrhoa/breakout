using System;
using System.Collections.Generic;
using System.Text;
using static breakout.Utility;

namespace breakout
{
    class World
    {
        List<Character> Characters = new List<Character>()
        {
            new Villain() {CommonName = "Bad Guy"},
            new Hero() {CommonName = "Good Guy"}
        };

        public void Start()
        {
            foreach(Character c in Characters)
            {
                Print($"{c.CommonName}");
            }
            
            Console.ReadKey();
        }

    }
}
