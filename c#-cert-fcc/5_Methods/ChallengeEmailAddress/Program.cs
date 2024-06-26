string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";
string internalDomain = "contoso.com";

void DisplayInternal(string[,] corporate)
{
    for (int i = 0; i < corporate.GetLength(0); i++) 
    {
        string firstInitial = corporate[i, 0].Substring(0, 1);
        firstInitial = firstInitial.ToLower();
        Console.WriteLine($"{firstInitial}{corporate[i, 1].ToLower()}@{internalDomain}");
    }
}


void DisplayExternal(string[,] external)
{
    for (int i = 0; i < external.GetLength(0); i++) 
    {
        string firstInitial = external[i, 0].Substring(0, 1);
        firstInitial = firstInitial.ToLower();
        Console.WriteLine($"{firstInitial}{external[i, 1].ToLower()}@{externalDomain}");
    }
}


DisplayInternal(corporate);
DisplayExternal(external);