/*
Randomly generate 'heads' or 'tails' using the Random class. Use and inline conditional to display 
the result of the coin flip. 
*/

Random random  = new Random();

int flip = random.Next(0, 2);

Console.WriteLine(flip == 0 ? "heads" : "tails"); // if flip is 0, print heads, else print tails