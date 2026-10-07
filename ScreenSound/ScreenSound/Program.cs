// Usually variables are declared in CamelCase
using ScreenSound.Challanges;

string welcomeMessage = "Welcome to Screen Sound!";
List<string> bands = new List<string> { "The Strokes", "Alan Walker", "Imagine Dragons" };

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
    Console.WriteLine("Type 99 to view challanges");
    Console.WriteLine("Type 0 to exit");
    
    Console.Write("\nPlease enter your choice: ");
    string choice = Console.ReadLine()!;
    int parsedChoice = int.Parse(choice);

    switch (parsedChoice)
    { 
        case 1: RegisterBands(); break;
        case 2: ShowRegisteredBands(); break;
        case 3: Console.WriteLine("You choose option " + parsedChoice); break;
        case 4: Console.WriteLine("You choose option " + parsedChoice); break;
        case 0: Console.WriteLine("You choose option " + parsedChoice); break;
        case 99: DisplayChallanges(); break;
        default: Console.WriteLine("Invalid option"); break;
    }

}

void RegisterBands()
{
    Console.Clear();
    Console.WriteLine("Register a new band");
    Console.Write("Enter the band name: ");
    string bandName = Console.ReadLine()!;
    bands.Add(bandName);
    Console.WriteLine($"Band {bandName} registered successfully!");
    Thread.Sleep(2000);
    Console.Clear();
    ShowMenuOptions();
}

void ShowRegisteredBands()
{
    Console.Clear();
    Console.WriteLine("Registered bands:");
    foreach (var band in bands)
    {
        Console.WriteLine(band);
    }
    Console.WriteLine("\nPress any key to return to the menu...");
    Console.ReadKey();
    Console.Clear();
    ShowMenuOptions();
}

ShowMenuOptions();

void DisplayChallanges()
{
    Console.Clear();
    Console.WriteLine("Challanges:");
    Console.WriteLine("1 - Challange One");
    Console.WriteLine("2 - Challange Two");
    Console.WriteLine("0 - Return to main menu");

    Console.Write("\nPlease enter your choice: ");
    string choice = Console.ReadLine()!;
    int parsedChoice = int.Parse(choice);
    switch (parsedChoice)
    {
        case 1:
            ChallangeOne challangeOne = new ChallangeOne();
            challangeOne.Challange();
            break;
        case 2:
            ChallangeTwo challangeTwo = new ChallangeTwo();
            challangeTwo.Challange();
            break;
        case 0: ShowMenuOptions(); break;
        default:
            Console.WriteLine("Invalid option");
            Thread.Sleep(2000);
            DisplayChallanges();
            break;
    }
    ShowMenuOptions();
}
