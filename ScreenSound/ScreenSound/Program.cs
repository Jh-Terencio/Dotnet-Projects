// Usually variables are declared in CamelCase
using ScreenSound.Challanges;

string welcomeMessage = "Welcome to Screen Sound!";

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
    Console.WriteLine("Type 0 to exit");
    
    Console.Write("\nPlease enter your choice: ");
    string choice = Console.ReadLine()!;
    int parsedChoice = int.Parse(choice);

    switch (parsedChoice)
    { 
        case 1: RegisterBands(); break;
        case 2: Console.WriteLine("You choose option " + parsedChoice); break;
        case 3: Console.WriteLine("You choose option " + parsedChoice); break;
        case 4: Console.WriteLine("You choose option " + parsedChoice); break;
        case 0: Console.WriteLine("You choose option " + parsedChoice); break;
        default: Console.WriteLine("Invalid option"); break;
    }

}

void RegisterBands()
{
    Console.Clear();
    Console.WriteLine("Register a new band");
    Console.Write("Enter the band name: ");
    string bandName = Console.ReadLine()!;
    Console.WriteLine($"Band {bandName} registered successfully!");
    Thread.Sleep(2000);
    Console.Clear();
    ShowMenuOptions();
}

ShowMenuOptions();

// Desafios
//ChallangeOne challangeOne = new ChallangeOne();
//challangeOne.Challange();
