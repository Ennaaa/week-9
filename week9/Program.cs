

string fileDirectoryPath = "C:\\Users\\denys\\OneDrive\\Рабочий стол\\Week1FirstApp\\Message";
string fileName = "chuck.txt";

string fullFilePath = Path.Combine(fileDirectoryPath, fileName);

ReadFromFile(fullFilePath);

static void DisplayDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}

static void ReadFromFile(string filePath)
{
    if (File.Exists(filePath))
    {
        string[] tempArray = File.ReadAllLines(filePath);
        Console.WriteLine($"There are {tempArray.Length} lines in the file.");
        Console.WriteLine("Do you want to see all lines or pick one? all/random");
        string userChoice = Console.ReadLine();

        if (userChoice == "all")
        {
            DisplayDataFromArray(tempArray);
        }
        else if (userChoice == "random")
        {
            DisplayRandomElement(tempArray);
        }
        else
        {
            Console.WriteLine("Try again.");
        }
    }
    else
    {
        Console.WriteLine($"File was not found.");
    }
}

static void DisplayRandomElement(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    Console.WriteLine(someArray[randomIndex]);
}