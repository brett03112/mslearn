/*

    In this challenge, you'll implement decision logic based on a series of business rules. 
    The business rules specify the access that will be granted to users based on their role-based permissions and their career level. 
    The Code branches will display a different message to the user depending on their permissions and level.

*/

string permission = "Manager";
int level = 40;

// Implement the business logic

if (permission.Contains("Admin") && level > 55)
{
    Console.WriteLine("Welcome, Super Admin user.");
}
else if (permission.Contains("Admin") && level <= 55)
{
    Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("Manager") && level > 20 && !permission.Contains("Admin"))
{
    Console.WriteLine("Contact an Admin for access.");
}
else{
    Console.WriteLine("You do not have sufficient privileges.");
}
