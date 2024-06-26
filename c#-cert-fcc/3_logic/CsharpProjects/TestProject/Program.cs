/*

Console.Write("1: ");
Console.WriteLine("a" == "a"); //True

Console.Write("2: ");
Console.WriteLine("a" == "A");//False

Console.Write("3: ");
Console.WriteLine(1 == 2);//False

string myValue = "a";
Console.Write("4: ");
Console.WriteLine(myValue == "a");//True

string value1 = " a";
string value2 = "A ";
Console.Write("5: ");
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());//True

Console.WriteLine($"'a' != 'a': {"a" != "a"}"); // False
Console.WriteLine($"'a' != 'A': {"a" != "A"}"); // True
Console.WriteLine($"1 != 2: {1 != 2}"); // True

string myValue1 = "a";
Console.WriteLine($"myValue1 != 'a': {myValue1 != "a"}"); // False

Console.WriteLine($"1 > 2: {1 > 2}"); // False
Console.WriteLine($"1 < 2: {1 < 2}"); // True
Console.WriteLine($"1 >= 1:  {1 >= 1}");// True
Console.WriteLine($"1 <= 1: {1 <= 1}");// True

string pangram = "The quick brown fox jumps over the lazy dog";
Console.WriteLine(pangram.Contains("fox")); // True
Console.WriteLine(pangram.Contains("cow")); // False

int a = 7;
int b = 6;
Console.WriteLine($"a != b: {a != b}"); // True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine($"s1 != s2: {s1 != s2}"); // False

// Conditional operators

// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50; // if saleAmount > 1000 then discount = 100 else discount = 50
Console.WriteLine($"Discount: {discount}"); // Discount: 100

//inline conditional operator
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}"); // Discount: 100



int value1 = 5;


if (value1 > 0)
{
    int value2 = 6;
    value1 += value2;    
}


Console.WriteLine(value1);

bool flag = true;
if (flag)
    Console.WriteLine(flag);

string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");





*/

// Using a while loop inside a for loop
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}