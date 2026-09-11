// Usually variables are declared in CamelCase
string welcomeMessage = "Welcome to Screen Sound!";

// Usually methods are declared in PascalCase
void ShowWelcomeMessage()
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
        case 1: Console.WriteLine("You choose option " + parsedChoice); break;
        case 2: Console.WriteLine("You choose option " + parsedChoice); break;
        case 3: Console.WriteLine("You choose option " + parsedChoice); break;
        case 4: Console.WriteLine("You choose option " + parsedChoice); break;
        case 0: Console.WriteLine("You choose option " + parsedChoice); break;
        default: Console.WriteLine("Invalid option"); break;
    }

}

void ChallangeOne()
{
    Console.WriteLine("-------------------- Part 1 --------------------");
    Console.Write("\nPlease enter the student average exams score: ");
    int averageExamScore = int.Parse(Console.ReadLine()!);

    if (averageExamScore >= 5)
    {
        Console.WriteLine("Average Exam Score is enough to be approved");
    }

    Console.WriteLine("-------------------- Part 2 --------------------");
    string studentName = "Terêncio";
    Console.WriteLine("Hello" + studentName);

    Console.WriteLine("-------------------- Part 3 --------------------");
    Console.Write("\nPlease enter a number: ");
    int number = int.Parse(Console.ReadLine()!);
    void SayNumberType(int number)
    {
        if (number < 0)
        {
            Console.WriteLine("The number is negative");
        }
        else if (number > 0)
        {
            Console.WriteLine("The number is positive");
        }
        else
        {
            Console.WriteLine("The number is zero");
        }
    }

    SayNumberType(number);
    
    Console.WriteLine("-------------------- Part 4 --------------------");
    Console.Write("\nPlease enter a number to see the the number position in a list: ");
    int numberPosition = int.Parse(Console.ReadLine()!);
    void SearchListPosition(int number)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < number + 1; i++)
        {
            list.Add(i*2);
        }

        Console.WriteLine(list[number]);
    }

    SearchListPosition(numberPosition);
}

ShowWelcomeMessage();
ShowMenuOptions();
ChallangeOne();
