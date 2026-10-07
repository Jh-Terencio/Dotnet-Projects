using ScreenSound.Challanges.Interfaces;
using System.Reflection;

namespace ScreenSound.Challanges
{
    public class ChallengeManager
    {
        private readonly Dictionary<int, IChallange> _challenges;

        public ChallengeManager()
        {
            _challenges = DiscoverChallenges();
        }

        private Dictionary<int, IChallange> DiscoverChallenges()
        {
            var challengeTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(IChallange).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .OrderBy(t => t.Name);

            var challenges = new Dictionary<int, IChallange>();
            int index = 1;
            foreach (var type in challengeTypes)
            {
                if (Activator.CreateInstance(type) is IChallange challenge)
                {
                    challenges[index++] = challenge;
                }
            }
            return challenges;
        }

        public void DisplayChallenges()
        {
            Console.Clear();

            Console.WriteLine("Challenges:");
            foreach (var kvp in _challenges)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value.Name}: {kvp.Value.Description}");
            }
            Console.WriteLine("0 - Return to main menu");

            Console.Write("\nPlease enter your choice: ");
            string choice = Console.ReadLine()!;

            if (!int.TryParse(choice, out int parsedChoice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Thread.Sleep(2000);
                DisplayChallenges();
                return;
            }

            if (parsedChoice == 0)
            {
                return;
            }

            if (_challenges.TryGetValue(parsedChoice, out var challenge))
            {
                Console.Clear();
                Console.WriteLine($"=== {challenge.Name} ===\n");
                challenge.Challange();
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid option");
                Thread.Sleep(2000);
            }

            DisplayChallenges();
        }
    }
}
