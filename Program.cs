﻿namespace Numberguesser;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playagain = true;
        int min = 1;
        int max = 100;
        int guess;
        int number;
        int guesses;
        String response;


        while(playagain)
        {
            guess = 0;
            guesses = 0;
            response = "";
            number = random.Next(min, max + 1);

            while (guess != number)
            {
                Console.WriteLine("Guess a number between 1 and 100");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess: " + guess);

                if (guess > number)
                {
                    Console.WriteLine(guess + " is to high");
                }
                else if (guess < number)
                {

                    Console.WriteLine(guess + " is to low");
                }
                guesses++;
            }
            Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN! ");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again?");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playagain = true;
                }
                else
                {
                    playagain = false;
                }
            
        }


        Console.WriteLine("thanks for playing!");




        Console.ReadKey();
    }
}

