/*
    The Contoso Shopping Center is having a super sale! Many items have discounted price. 
    You're given a list of item prices and a list of corresponding discounts. 
    The discounts are represented by percentages, for example 50% = 0.5. 
    If a customer spends more than $30.00, they recieve $5.00 of their total purchase. 
    In this task, you'll write code to calculate the customer's total.
*/
/*
double total = 0;
double minimumSpend = 30.00;

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

if (TotalMeetsMinimum())
{
    total -= 5.00;
}

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    // Calculate the discounted price of the item
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    // Check if the total meets the minimum
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    // Format the double so only 2 decimal places are displayed
    return input.ToString().Substring(0,5);
}
*/

//Excercise:  Return numbers from methods

double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd) 
{
    int rate = 23500;
    return (int) (rate * usd);
}

double VndToUsd(int vnd) 
{
    double rate = 23500;
    return vnd / rate;
}

Console.WriteLine();
//reverse words in a string
string ReverseSentence(string input) 
{
    string result = "";
    string[] words = input.Split(" ");

    foreach(string word in words) 
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();
}

//reverse a word or string
string ReverseWord(string word) 
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--) 
    {
        result += word[i];
    }
    return result;
}
string input = "snakes are mean";

Console.WriteLine(input);
Console.WriteLine(ReverseWord(input));
Console.WriteLine(ReverseSentence(input));
Console.WriteLine();


bool IsPalindrome(string word) 
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end) 
    {
        if (word[start] != word[end]) 
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}

string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

Console.WriteLine("Is it a palindrome?");
foreach (string word in words) 
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}
Console.WriteLine();
//returning arrays from methods
/*
    Suppose you have several coins of different values. 
    You're tasked to find two coins whose sum is equal to a target value. In this exercise, 
    the coins available are represented in an integer array. You'll need to return the indices of the two coins in a new array.
*/
int target = 30;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[,] result = TwoCoins(coins, target);

if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result.GetLength(0); i++) 
    {
        if (result[i,0] == -1) 
        {
            break;
        }
        Console.WriteLine($"{result[i,0]},{result[i,1]}");
    }
}

int[,] TwoCoins(int[] coins, int target) 
{
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++) 
    {
        for (int next = curr + 1; next < coins.Length; next++) 
        {    
            if (coins[curr] + coins[next] == target) 
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0)) 
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0,0] : result;
}
