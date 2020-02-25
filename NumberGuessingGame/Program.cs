using System;

namespace NumberGuessingGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool gameStatus = true;
            var rand = new Random();
            string guess;
            int numGuess;
            int chosenNumber = rand.Next(101);
            //Console.WriteLine(chosenNumber);

            Console.WriteLine("I have chosen a number between 1 and 100.  See if you can guess what it is!");
            Console.WriteLine("Please enter your first guess: ");
            guess = Console.ReadLine();
            //checkForInteger(guess);
            numGuess = Int32.Parse(guess);
            while (gameStatus == true)
            {
                if (numGuess == chosenNumber)
                {
                    Console.WriteLine("You guessed correctly!");
                    gameStatus = false;
                }

                else if (numGuess > chosenNumber)
                {
                    Console.WriteLine("Your guess is too high!");
                }

                else if (numGuess < chosenNumber)
                {
                    Console.WriteLine("Your guess is too low!");
                }
                if (gameStatus == true)
                {
                    Console.WriteLine("Please enter a new guess: ");
                    guess = Console.ReadLine();
                    numGuess = Int32.Parse(guess);
                }
            }
            Console.WriteLine("Thanks for playing!");
        }

        public bool checkForInteger(string guess)
        {
            int numGuess = Int32.Parse(guess);
            if (int.TryParse(guess, out numGuess))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
