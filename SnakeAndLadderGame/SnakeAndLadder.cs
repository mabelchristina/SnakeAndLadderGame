
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderGame
{
    class SnakeAndLadder
    {
        int playerposition = 0;
        public void Play()
        {
            Random random = new Random();
            int number = random.Next(1, 7);
            Console.WriteLine("Player rolled the dice and got " + number + " number");
        }
    }
}
