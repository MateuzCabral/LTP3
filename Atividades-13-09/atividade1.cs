using System;

namespace ComparacaoDeValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, insira sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor, insira sua altura em centímetros:");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Por favor, insira seu peso:");
            double peso = Convert.ToDouble(Console.ReadLine());


            if (idade >= 18 && altura >= 170)
            {
                Console.WriteLine("Você é maior de 18 anos e tem mais de 170 cm de altura.");
            }
            else if (idade >= 18 || altura >= 170)
            {

                if (idade >= 18 && altura < 170)
                {
                    Console.WriteLine("Você é maior de 18 anos,mas tem menos de 170 cm de altura");
                }
                if (altura >= 170 && idade < 18)
                {
                    Console.WriteLine("Você tem mais de 170 cm de altura,mas é menor de 18 anos");
                }
            }
            else
            {
                Console.WriteLine("Você não atende a nenhum dos critérios acima.");
            }

            double alturaMetro = altura / 100.0;
            double imc = peso / (alturaMetro * alturaMetro);

            switch (imc)
            {
                case < 18.5:
                    Console.WriteLine($"Seu IMC é de {imc:C2} Você está abaixo do peso");
                    break;

                case < 24.9:
                    Console.WriteLine($"Seu IMC é de {imc:C2} Você está no peso normal");
                    break;

                case < 29.9:
                    Console.WriteLine($"Seu IMC é de {imc:C2} Você está com Sobrepeso");
                    break;

                case < 34.9:
                    Console.WriteLine($"Seu IMC é de {imc:C2} Você está com Obesidade Grau I");
                    break;

                case < 39.9:
                    Console.WriteLine($"Seu IMC é de {imc:C2} Você está com Obesidade Grau II");
                    break;

                case >= 40:
                    Console.WriteLine($"Seu IMC é de {imc:C2} Você está com Obesidade Grau III");
                    break;
            }
        }
    }
}