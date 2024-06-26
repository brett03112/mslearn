/*
    Write a program that finds a specific number, counting each item in an array until if finds the number.
    Then prints that it finds the number and the total so far.
*/


int[] numbers = { 4, 8, 15, 16, 23, 42 };

bool found = false;
int total = 0;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
       found = true;
       break;
    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");
}

Console.WriteLine($"Total: {total}");

