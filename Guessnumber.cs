using System;

namespace Number_Guessing_Game
{
    class Guessnumber
    {
        static void Main(string[] args)
        {
            // Choose the game mode (player or computer)
            Console.WriteLine("Choose the game mode:");
            Console.WriteLine("[1] Player guessing");
            Console.WriteLine("[2] Computer guessing");
            string userInputString = Console.ReadLine();

            // Additional condition to check if userInput is not a character
            if (int.TryParse(userInputString, out int userInput))
            {
                if (!(userInput == 1 || userInput == 2))
                {
                    Console.WriteLine("The number is not 1 or 2.");
                }
                else
                {
                    // Player guessing mode
                    if (userInput == 1)
                    {
                        Console.WriteLine("Think of a number between 1 and 10,000.");
                        Console.WriteLine("Press Enter when you're ready.");
                        Console.ReadLine();

                        int min = 1;
                        int max = 10000;
                        int guess = (min + max) / 2;

                        while (true)
                        {
                            Console.WriteLine("Is your number " + guess + "?");
                            Console.WriteLine("[1] Too low");
                            Console.WriteLine("[2] Too high");
                            Console.WriteLine("[3] Correct");
                            int response = int.Parse(Console.ReadLine());

                            if (response == 1)
                            {
                                min = guess + 1;
                            }
                            else if (response == 2)
                            {
                                max = guess - 1;
                            }
                            else if (response == 3)
                            {
                                Console.WriteLine(" Bingo!! This was the number you were thinking");
                                break;
                            }

                            guess = (min + max) / 2;
                        }
                    }

                    // Computer guessing mode
                    else if (userInput == 2)
                    {
                        int computerNumber = new Random().Next(1, 10001);

                        Console.WriteLine("I'm thinking of a number between 1 and 10,000.");
                        Console.WriteLine("What do you think my number is.");

                        int guess;

                        while (true)
                        {
                            guess = int.Parse(Console.ReadLine());

                            if (guess < computerNumber)
                            {
                                Console.WriteLine("Too low.");
                            }
                            else if (guess > computerNumber)
                            {
                                Console.WriteLine("Too high.");
                            }
                            else
                            {
                                Console.WriteLine("You guessed my number correctly!");
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}