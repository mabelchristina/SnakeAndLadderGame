﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderGame
{
    class SnakeAndLadder
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        int playerposition;
        public void Play()
        {
            Random random = new Random();
            int rollDie = random.Next(1, 7);
            int options = random.Next(0, 3);
            switch (options)
            {
                case NO_PLAY:
                    Console.WriteLine("NO_PLAY");
                    playerposition = 0;
                    break;
                case LADDER:
                    Console.WriteLine("LADDER");
                    playerposition += rollDie;
                    break;
                case SNAKE:
                    Console.WriteLine("SNAKE");
                    playerposition -= rollDie;
                    if (playerposition < 0)
                    {
                        playerposition = 0;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("Player is at " + playerposition);
        }
    }
}