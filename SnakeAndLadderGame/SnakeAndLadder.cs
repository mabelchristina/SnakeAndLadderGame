using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderGame
{
    class SnakeAndLadder
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WIN_POSITION = 100;
        int playerposition = 0, count = 0;
        public void Play()
        {
            Random random = new Random();
            int rollDie = random.Next(1, 7);
            int options = random.Next(0, 3);
            while (playerposition < WIN_POSITION)
            {
                count++;
                switch (options)
                {
                    case NO_PLAY:
                        Console.WriteLine("NO_PLAY");
                        playerposition += 0;
                        break;
                    case LADDER:
                        Console.WriteLine("LADDER");
                        playerposition += rollDie;
                        break;
                    case SNAKE:
                        Console.WriteLine("SNAKE");
                        playerposition -= rollDie;
                        break;
                    default:
                        break;
                }
                if (playerposition <= 0)
                {
                    playerposition = 0;
                    Console.WriteLine("player is at zeroth position");
                    break;
                }
                if (playerposition > WIN_POSITION)
                {
                    playerposition -= rollDie;
                }
                if (playerposition == WIN_POSITION)
                {
                    Console.WriteLine(count + " no of times die roll");
                    break;
                }
                Console.WriteLine("Player is at " + playerposition);
            }
        }
    }
}
