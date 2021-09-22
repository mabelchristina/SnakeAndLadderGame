using System;

namespace SnakeAndLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            SnakeAndLadder snakeAndLadder = new SnakeAndLadder();
            int player1 = snakeAndLadder.Play(0);
            int player2 = snakeAndLadder.Play(0);
            if (player1.CompareTo(player2) == 0)
            {
                Console.WriteLine("Both Players at same position " + player1 + ",Its a Tie ");
            }
            if (player1.CompareTo(player2) > 0)
            {
                Console.WriteLine("Player1 wins " + player1);
            }
            if (player1.CompareTo(player2) < 0)
            {
                Console.WriteLine("Player2 wins " + player2);
            }
            Console.ReadLine();
        }
    }
}
