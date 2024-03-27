namespace CSharpTutorialMarch24.GuessingGame;

public class GameBuilder
{
    public static void Game()
    {
        Console.WriteLine("Guess the secret word! You have an unlimited amount of tries .. ");
        string secretWord = "giraffe";
        string guess = "";
        int guesses = 0;
        while (guess != secretWord)
        {
            Console.WriteLine("Enter guess:");
            guess = Console.ReadLine();
            guesses += 1;
            if (guess != secretWord)
            {
                Console.WriteLine("FAIL!!");
                
            }
        }

        if (guesses <= 5)
        {
            Console.WriteLine($"Nicely done! You did it in only {guesses} guesses!");
        }
        else
        {
            Console.WriteLine($"You are bad at this, {guesses} guesses? Pathetic.");
        }

        Console.Read();
    }
}