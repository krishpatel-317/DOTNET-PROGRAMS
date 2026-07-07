Random rand = new Random();
int secretNumber = rand.Next(1, 101);
int guess;
int attempts = 0;

do
{
    Console.Write("Enter your guess (1-100): ");
    guess = Convert.ToInt32(Console.ReadLine());
    attempts++;

    if (guess > secretNumber)
    {
        Console.WriteLine("Too high!");
    }
    else if (guess < secretNumber)
    {
        Console.WriteLine("Too low!");
    }

} while (guess != secretNumber);

Console.WriteLine("Congratulations! You guessed the correct number.");
Console.WriteLine("Total attempts: " + attempts);