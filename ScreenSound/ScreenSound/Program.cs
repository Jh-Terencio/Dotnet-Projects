// Usually variables are declared in CamelCase
using ScreenSound.Challanges;

string welcomeMessage = "Welcome to Screen Sound!";
Dictionary<string, List<int>> bands = new Dictionary<string, List<int>>();
ChallengeManager challengeManager = new ChallengeManager();

// Usually methods are declared in PascalCase
void ShowLogo()
{
    // This multiline string was generated using this site https://fsymbols.com/#google_vignette
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(welcomeMessage);
}

void ShowMenuOptions()
{
    ShowLogo();
    Console.WriteLine("\nType 1 to register a band");
    Console.WriteLine("Type 2 to show all bands");
    Console.WriteLine("Type 3 to rate a band");
    Console.WriteLine("Type 4 to view a band average rating");
    Console.WriteLine("Type 5 to view challenges");
    Console.WriteLine("Type 0 to exit");

    Console.Write("\nPlease enter your choice: ");
    string choice = Console.ReadLine()!;

    if (!int.TryParse(choice, out int parsedChoice))
    {
        Console.WriteLine("Invalid input. Please enter a number.");
        Thread.Sleep(2000);
        Console.Clear();
        ShowMenuOptions();
        return;
    }

    switch (parsedChoice)
    {
        case 1: RegisterBands(); break;
        case 2: ShowRegisteredBands(); break;
        case 3: RateBand(); break;
        case 4: ShowBandAverageRating(); break;
        case 5: challengeManager.DisplayChallenges(); break;
        case 0: Console.WriteLine("You choose option " + parsedChoice); break;
        default: Console.WriteLine("Invalid option"); break;
    }

}

void RegisterBands()
{
    Console.Clear();
    ShowTitleOptions("Register a new band");
    Console.Write("Enter the band name: ");
    string bandName = Console.ReadLine()!;

    if (string.IsNullOrWhiteSpace(bandName))
    {
        Console.WriteLine("Band name cannot be empty. Please try again.");
        Thread.Sleep(2000);
        Console.Clear();
        ShowMenuOptions();
        return;
    } else if (bands.ContainsKey(bandName))
    {
        Console.WriteLine($"Band {bandName} is already registered.");
        Thread.Sleep(2000);
        Console.Clear();
        ShowMenuOptions();
        return;
    }

    bands.Add(bandName, new List<int>());
    Console.WriteLine($"Band {bandName} registered successfully!");
    Thread.Sleep(2000);
    Console.Clear();
    ShowMenuOptions();
}
void ShowRegisteredBands()
{
    Console.Clear();
    ShowTitleOptions("Registered bands");
    foreach (var band in bands)
    {
        Console.WriteLine(band.Key);
    }
    Console.WriteLine("\nPress any key to return to the menu...");
    Console.ReadKey();
    Console.Clear();
    ShowMenuOptions();
}
void RateBand()
{
    Console.Clear();
    ShowTitleOptions("Rate a band");
    Console.Write("Enter the band name: ");
    string bandName = Console.ReadLine()!;
    if(!bands.ContainsKey(bandName))
    {
        Console.WriteLine($"Band {bandName} is not registered.");
        Console.WriteLine("\nBands available for rating:");
        var sortedBands = bands.OrderBy(b => b.Key).ToList();
        foreach (var band in sortedBands)
        {
            Console.WriteLine("- " + band.Key);
        }

        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
        Console.Clear();
        ShowMenuOptions();
    }

    Console.Write("Enter the rating (1 to 5): ");

    int rating;
    while (true)
    {
        Console.Write("Enter the rating (1 to 5): ");
        string ratingInput = Console.ReadLine()!;

        if (int.TryParse(ratingInput, out rating) && rating >= 1 && rating <= 5)
            break;

        Console.WriteLine("Invalid rating. Please enter a number between 1 and 5.");
    }

    bands[bandName].Add(rating);
    Console.WriteLine($"Rating of {rating} added for band {bandName}!");    
    Thread.Sleep(2000);
    Console.Clear();
    ShowMenuOptions();
}
void ShowBandAverageRating()
{
    Console.Clear();
    ShowTitleOptions("View band average rating");
    Console.Write("Enter the band name: ");
    string bandName = Console.ReadLine()!;
    if (!bands.ContainsKey(bandName))
    {
        Console.WriteLine($"Band {bandName} is not registered.");
        Console.WriteLine("\nBands available for rating:");
        var sortedBands = bands.OrderBy(b => b.Key).ToList();
        foreach (var band in sortedBands)
        {
            Console.WriteLine("- " + band.Key);
        }
        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
        Console.Clear();
        ShowMenuOptions();
    }
    List<int> ratings = bands[bandName];
    if (ratings.Count == 0)
    {
        Console.WriteLine($"Band {bandName} has no ratings yet.");
    }
    else
    {
        double averageRating = ratings.Average();
        Console.WriteLine($"The average rating for band {bandName} is {averageRating:F2}");
    }
    Console.WriteLine("\nPress any key to return to the menu...");
    Console.ReadKey();
    Console.Clear();
    ShowMenuOptions();
}

void ShowTitleOptions(string title)
{
    int titleLength = title.Length;
    string border = string.Empty.PadLeft(titleLength + 4, '=');
    Console.WriteLine(border);
    Console.WriteLine($"= {title} =");
    Console.WriteLine(border);
}

ShowMenuOptions();
