// for statements in C#

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}
Console.WriteLine();

//reverse loop
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
    if (i == 7) break;
}
Console.WriteLine();

// Loop through arrays
string[] names = {"Alex", "Eddie", "David", "Michael"};
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}
Console.WriteLine();

// Reverse loop
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
Console.WriteLine();

// foreach loop
string[] names1 = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names1.Length; i++)
    if (names1[i] == "David") names1[i] = "Sammy";

foreach (var name in names1) Console.WriteLine(name);