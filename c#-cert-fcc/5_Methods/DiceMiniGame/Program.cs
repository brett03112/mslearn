/*
    Your challenge is to design a mini-game. The game should select a target number 
    that is a random number between one and five (inclusive). The player must roll a six-sided dice. 
    To win, the player must roll a number greater than the target number. 
    At the end of each round, the player should be asked if they would like to play again, and the game should continue or terminate accordingly.
*/

//starter code
Random random = new Random();

string answer = "";
Console.WriteLine("Would you like to play? (Y/N)");
answer = Console.ReadLine();
if (ShouldPlay(answer)) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = random.Next(1, 6);
        var roll = random.Next(1, 6);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");
        answer = Console.ReadLine();

        play = ShouldPlay(answer);
    }
}

bool ShouldPlay(string answer)
{
    if (answer.ToLower() == "y" || answer.ToUpper() == "Y")
        return true;
    else if (answer.ToLower() == "n" || answer.ToUpper() == "N")
        return false;
    else
        Console.WriteLine("That is not a valid choice. Please choose Y or N.");
        return ShouldPlay(Console.ReadLine());
}

string WinOrLose(int a, int b)
{
    if (b > a)
        return "You win!";
    else
        return "You lose!";
}

