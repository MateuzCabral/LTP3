using System;

namespace Atividade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insira seu nome completo: ");
            string name = Console.ReadLine();

            Console.Write("Insira sua idade: ");
            int age = Int32.Parse(Console.ReadLine());

            // Nome completo em maiúsculas
            Console.WriteLine($"Nome completo em maiúsculas: {name.ToUpper()}");

            // Nome completo em minúsculas
            Console.WriteLine($"Nome completo em minúsculas: {name.ToLower()}");

            // Número de caracteres no nome
            int contador = 0;

            foreach (char letra in name){
                if (letra != ' '){
                    contador++;
                }else{
                    contador = contador;
                }
            }

            Console.WriteLine($"Seu nome tem {contador} letras.");

            // Ano de nascimento 
            int anoAtual = 2023;
            int anoNascimento = anoAtual - age;

            // Ano em que o usuário fará 100 anos
            int anoCemAnos = anoNascimento + 100;
            Console.WriteLine($"Ano de nascimento calculado: {anoNascimento}");
            Console.WriteLine($"Você fará 100 anos em: {anoCemAnos}");
        }
    }
}
