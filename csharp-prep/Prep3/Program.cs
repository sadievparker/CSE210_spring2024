using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess the magic number!");
        Random randonGen = new Random();
        int magicNum = randonGen.Next(1,11);

        int guess = -1;
        

        while ( guess != magicNum)
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            if (guess > magicNum )
            {
                
                Console.WriteLine("Too high");
            }
            else if ( guess < magicNum )
            {
                Console.WriteLine("Too low");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }

        }
    }
}