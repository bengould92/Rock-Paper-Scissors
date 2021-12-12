using System;

namespace Rock__Paper__Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;


            while (playAgain)
            {
                player = "";
                computer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS") // While player var does not equal rock, paper or scissors continue asking for input
                {
                    Console.Write("Enter ROCK, PAPER or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break ;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

            }

            Console.ReadKey();






        }
    }
}
