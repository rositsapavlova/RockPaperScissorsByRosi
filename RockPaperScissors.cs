using System;

namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            //player's choice
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";

            Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors: ");
            string playerInput = Console.ReadLine();

            if (playerInput == "r" || playerInput == "rock")
            {
                playerInput = rock;
            }
            else if (playerInput == "p" || playerInput == "paper")
            {
                playerInput = paper;
            }
            else if (playerInput == "s" || playerInput == "scissors")
            {
                playerInput = scissors;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again...");
                return;
            }
            //computer's choice
            Random random = new Random(); //stores randomly generated number
            int computerRandom = random.Next(1, 4); //generated number will be in the range from 1 to 3

            string computerInput = "";

            switch (computerRandom)
            {
                case 1:
                    computerInput = rock;
                    break;
                case 2:
                    computerInput = paper;
                    break;
                case 3:
                    computerInput = scissors;
                    break;
            }
            Console.WriteLine($"The computer chose {computerInput}.");

            //winner or looser
            if (playerInput == rock && computerInput == scissors || playerInput == paper && computerInput == rock || playerInput == scissors && computerInput == paper)
            {
                Console.WriteLine("You win.");
            }
            else if (playerInput == rock && computerInput == paper || playerInput == paper && computerInput == scissors || playerInput == scissors && computerInput == rock)
            {
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.WriteLine("This game was a draw.");
            }

        }
    }
}
