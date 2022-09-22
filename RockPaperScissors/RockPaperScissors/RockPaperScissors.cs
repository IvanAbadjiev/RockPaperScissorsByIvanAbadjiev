namespace RockPaperScissors
{
    using System;
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            //Three options to choose from
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scissors";

            //Prompting the client to make a move choice
            Console.Write("Choose [r]ock, [p]aper [s]cissors:  ");
            string playerMove = Console.ReadLine();

            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = rock;
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = scissors;
            }
            else
            {
                Console.WriteLine("Invalid Input. Try Again...");
                return;
            }


            //computer selection
            Random random = new Random();
            int computerRandomNuber = random.Next(1, 4);
            string computerMove = "";

            switch (computerRandomNuber)
            {
                case 1:
                    computerMove = rock;
                    break;
                case 2:
                    computerMove = paper;
                    break;
                case 3:
                    computerMove = scissors;
                    break;
                default:
                    break;
            }


            //Check and Write the Result
            Console.WriteLine($"The computer chose {computerMove}");

            if ((playerMove == rock && computerMove == scissors) ||
                (playerMove == paper && computerMove == rock) ||
                (playerMove == scissors && computerMove == paper))
            {
                Console.WriteLine("You win.");
            }
            else if ((playerMove == scissors && computerMove == rock) ||
                (playerMove == rock && computerMove == paper) ||
                (playerMove == paper && computerMove == scissors))
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
