using ScreenSound.Challanges.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenSound.Challanges
{
    internal class ChallangeTwo : IChallange
    {
        public void Challange()
        {
            // Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.
            Console.WriteLine("-------------------- Part 1 --------------------");
            Console.Write("Enter the first number: ");
            float n1 = float.Parse(Console.ReadLine()!);
            Console.Write("Enter the second number: ");
            float n2 = float.Parse(Console.ReadLine()!);
            Console.WriteLine(NumberBasicOperations((int)n1, (int)n2));

            // Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
            Console.WriteLine("-------------------- Part 2 --------------------");
            List<string> bands = new List<string>();
            bands.Add("The Beatles");
            bands.Add("Queen");
            bands.Add("Nirvana");
            bands.Add("Pink Floyd");

            // Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no consol
            Console.WriteLine("-------------------- Part 3 --------------------");
            foreach (var band in bands)
            {
                Console.WriteLine(band);
            }

            // Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.
            Console.WriteLine("-------------------- Part 4 --------------------");
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"Sum: {sum}");
        }

        public string NumberBasicOperations(int number1, int number2)
        {
            int sum = number1 + number2;
            int subtraction = number1 - number2;
            int multiplication = number1 * number2;
            double division = (double)number1 / number2;
            return $"Sum: {sum}\nSubtraction: {subtraction}\nMultiplication: {multiplication}\nDivision: {division}";
        }
    }
}
