using System;

namespace Simulado
{
    class Program
    {
        public static void RolarDado()
        {
            Random numberGen = new Random();
            const int totalDeLados = 6;
            int dadoUm = 0;
            int dadoDois = 0;
            bool jogarNovamente = true;
            int rodadas = 0;

            while (jogarNovamente)
            {
                dadoUm = numberGen.Next(1, totalDeLados + 1);
                dadoDois = numberGen.Next(1, totalDeLados + 1);
                Console.WriteLine($"Dado Um {dadoUm}");
                Console.WriteLine($"Dado Dois {dadoDois}");
                Console.WriteLine($"Você rolou dois dados de {totalDeLados} lados e obteve os números {dadoUm} e {dadoDois}.");
                int chanceDePar = Probabilidade(dadoUm + dadoDois);

                Console.Write("Deseja jogar novamente? (S/N): ");
                char resposta = Console.ReadKey().KeyChar;
                if (resposta != 's' && resposta != 'S')
                {
                    jogarNovamente = false;
                    Console.WriteLine("Obrigado por jogar!");
                }

                if (dadoUm % 2 == 0 && dadoDois % 2 == 0)
                {
                    rodadas++;
                }
            }
            Console.WriteLine("Você Precisou de: " + rodadas + " rodadas para conseguir uma sequência de números pares.");
        }

        public static int Probabilidade(int totalDeLados)
        {
            double porcentagem = (totalDeLados / 2.0) / totalDeLados * 100;
            Console.WriteLine("A possibilidade de sair um número par em dois dados é de: " + porcentagem + "%");
            return (int)porcentagem;
        }
    }
}