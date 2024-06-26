/*
    Implement a 'FizzBuzz' program that iterates through numbers 1 to 100 and
    prints 'Fizz' if the number is divisible by 3, 'Buzz' if the number is
    divisible by 5, and 'FizzBuzz' if the number is divisible by both.
*/

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}