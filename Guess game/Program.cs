using System;

public class Program
{
    public void Main(string[] args)
    {   

        string secret = "Hotdog";
        string plrGuess = "";
        int guess_num = 0;
        int guess_limit = 3;

        do
        {
            Console.Write("guess the secret word: ");
            plrGuess = Console.ReadLine();
            guess_num++;
        } while(guess_num < guess_limit && plrGuess != secret);
        if(plrGuess == secret)
        {
            Console.WriteLine("wow you win!!");
        }
        else
        {
            Console.WriteLine("you lose!!");
        }

    }

}

