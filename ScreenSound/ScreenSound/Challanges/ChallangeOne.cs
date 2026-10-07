using ScreenSound.Challanges.Interfaces;

namespace ScreenSound.Challanges
{
    public class ChallangeOne : IChallange
    {
        public string Name => "Challenge One";
        public string Description => "Basic conditionals and list operations";

        public void Challange()
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
                    list.Add(i * 2);
                }

                Console.WriteLine(list[number]);
            }

            SearchListPosition(numberPosition);
        }
    }
}
