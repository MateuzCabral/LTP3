// Calculadora de console usando o switch case em c#
using System;

namespace Calculadora
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(
                "----  Calculator Menu  ----\n"
                + "1. Adição\n"
                + "2. Subtração\n"
                + "3. Multiplicação\n"
                + "4. Divisão"
            );

            Console.Write("Informe Sua Escolha: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe Dois Numeros da Operação: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($">> {num1} + {num2} = {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($">> {num1} - {num2} = {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($">> {num1} * {num2} = {num1 * num2}");
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("ERRO: Impossivel Dividir Por 0");
                    }
                    else
                    {
                        Console.WriteLine($">> {num1} / {num2} = {num1 / num2}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }
    }
}