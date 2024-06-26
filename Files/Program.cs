using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

// Get the current directory
var currentDirectory = Directory.GetCurrentDirectory();
// Get the .stores directory
var storesDirectory = Path.Combine(currentDirectory, "stores");

// Create the salesTotalDir
var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir);

// Find all 'sales.json' files in the .stores directory
var salesFiles = FindFiles(storesDirectory);

// Calculate the sales total
var salesTotal = CalculateSalesTotal(salesFiles);

// Write the sales total to the totals.txt file in salesTotalDir
File.AppendAllText(Path.Combine(salesTotalDir, "totals.txt"), $"{salesTotal}{Environment.NewLine}");





/// <summary>
/// FindFiles function returns a list of 'sales.json' files in the given folder
/// and subfolders then prints them to the console with their respective paths
/// </summary>
/// <param name=string "folderName"></param>
/// <returns>List<string> salesFiles</returns>
/// <example>FindFiles(@"C:\sales\stores\202");</example>
IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        var extension = Path.GetExtension(file);
        // The file name will contain the full path, so only check the end of it
        if (extension == ".json")
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}

/// <summary>
/// CalculateSalesTotal function takes in a list of 'sales.json' files
/// and returns the total sales amount
/// </summary>
/// <param name="salesFiles"></param>
/// <returns>double salesTotal</returns>
double CalculateSalesTotal(IEnumerable<string> salesFiles)
{
    double salesTotal = 0;

    // Loop over each file path in salesFiles
    foreach (var file in salesFiles)
    {      
        // Read the contents of the file
        string salesJson = File.ReadAllText(file);

        // Parse the contents as JSON
        SalesData? data = JsonConvert.DeserializeObject<SalesData?>(salesJson);

        // Add the amount found in the Total field to the salesTotal variable
        salesTotal += data?.Total ?? 0;
    }

    return salesTotal;
}
record SalesData (double Total);