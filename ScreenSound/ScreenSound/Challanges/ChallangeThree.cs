using ScreenSound.Challanges.Interfaces;

namespace ScreenSound.Challanges
{
    public class ChallangeThree : IChallange
    {
        public string Name => "Challenge Three";
        public string Description => "Dictionaries";

        public void Challange()
        {
            // Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
            Console.WriteLine("-------------------- Part 1 --------------------");
            Dictionary<string, List<int>> students = new Dictionary<string, List<int>>();
            students.Add("Joao Terencio", new List<int> { 10, 8, 9 });
            students.Add("Maria Silva", new List<int> { 9, 7, 8 });

            foreach (var student in students)
            {
                string name = student.Key;
                List<int> grades = student.Value;
                double average = grades.Average();
                Console.WriteLine($"Student: {name}, Average Grade: {average}");
            }

            // Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.
            Console.WriteLine("-------------------- Part 2 --------------------");
            Dictionary<string, int> products = new Dictionary<string, int>();
            products.Add("Computer", 1000);
            products.Add("Mouse", 50);
            products.Add("Keyboard", 100);

            Console.WriteLine("Enter a product name to see the stock:");
            string productName = Console.ReadLine();

            if (products.ContainsKey(productName))
            {
                Console.WriteLine($"Stock for {productName}: {products[productName]}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }

            // Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.
            Console.WriteLine("-------------------- Part 3 --------------------");
            Dictionary<string, Dictionary<List<string>, int>> quiz = new Dictionary<string, Dictionary<List<string>, int>>();
            quiz.Add("Question 1 - Qual a capital do Brasil?", new Dictionary<List<string>, int>
            {
                { new List<string> { "Brasilia", "Rio de Janeiro", "Salvador" }, 1 }
            });
            quiz.Add("Question 2 - Qual a capital da França?", new Dictionary<List<string>, int>
            {
                { new List<string> { "Paris", "Lyon", "Marselha" }, 1 }
            });
            quiz.Add("Question 3 - Qual a capital da Alemanha?", new Dictionary<List<string>, int>
            {
                { new List<string> { "Berlim", "Hamburgo", "Munique" }, 1 }
            });

            int score = 0;

            foreach(var question in quiz)
            {
                Console.WriteLine(question.Key);
                var options = question.Value.Keys.First();
                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {options[i]}");
                }
                Console.Write("Enter the number of your answer: ");
                int answer = int.Parse(Console.ReadLine()!);
                if (answer == question.Value.Values.First())
                {
                    score++;
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }

            Console.WriteLine($"Your score: {score}/{quiz.Count}");


            // Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.
            Console.WriteLine("-------------------- Part 4 --------------------");
            Dictionary<string, string> users = new Dictionary<string, string>();
            users.Add("admin", "password");
            users.Add("user1", "pass1");
            users.Add("user2", "pass2");

            Console.Write("Enter username: ");
            string username = Console.ReadLine()!;
            Console.Write("Enter password: ");
            string password = Console.ReadLine()!;

            if (users.ContainsKey(username) && users[username] == password)
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }
        }
    }
}
