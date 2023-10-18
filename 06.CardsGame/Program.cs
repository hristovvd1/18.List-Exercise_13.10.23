using System.Collections.Generic;

namespace _06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> player2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (player1.Count > 0 && player2.Count > 0)
            {
                int playerOneCard = player1[0];
                int playerTwoCard = player2[0];

                if (playerOneCard > playerTwoCard)
                {
                    player1.Add(playerTwoCard);
                    player1.Add(playerOneCard);
                    player2.RemoveAt(0);
                    player1.RemoveAt(0);
                }

                else if (playerTwoCard > playerOneCard)
                {
                    player2.Add(playerOneCard);
                    player2.Add(playerTwoCard);
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }

                else
                {
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }
            }

            if (player1.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {Sum(player1)}");
            }

            else if (player2.Count > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {Sum(player2)}");

            }

            else
            {
                Console.WriteLine("No player wins! Sum: 0");
            }
        }

        private static int Sum(List<int> list)
        {
            int sum = 0;

            foreach (int item in list)
            {
                sum += item;
            }

            return sum;
        }
    }
}
