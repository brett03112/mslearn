// do - while and while loops in C#
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);



Random random1 = new Random();
int current1 = random1.Next(1, 11);


//do
//{
    //current = random.Next(1, 11);
    //Console.WriteLine(current);
//} while (current != 7);


while (current1 >= 3)
{
    Console.WriteLine(current1);
    current1 = random1.Next(1, 11);
}
Console.WriteLine($"Last number: {current1}");


Random random2 = new Random();
int current2 = random2.Next(1, 11);

do
{
    current2 = random2.Next(1, 11);

    if (current2 >= 8) continue;

    Console.WriteLine(current2);
} while (current2 != 7);


// differences between do - while and while
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();


string? readResult1;
string roleName = "";
bool validEntry = false;

do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult1 = Console.ReadLine();
    if (readResult1 != null) 
    {
        roleName = readResult1.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult1 = Console.ReadLine();