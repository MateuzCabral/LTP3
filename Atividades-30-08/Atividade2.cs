using System;

class Program
{

    static string nomeJoao = "joao";
    static string nomeMaria = "maria";
    static double contaJoao = 1000.0;
    static double contaMaria = 1500.0;

    static void Transferencia()
    {
        Console.Write("Digite o nome do remetente:");
        string remetente = Console.ReadLine();

        if ((remetente.ToLower() == nomeJoao) || (remetente.ToLower() == nomeMaria))
        {
            Console.Write("Digite o nome do beneficiário:");
            string beneficiario = Console.ReadLine();

            if ((remetente == nomeJoao && beneficiario == nomeMaria) || (remetente == nomeMaria && beneficiario == nomeJoao))
            {

                Console.Write("Digite o valor da transferência:");
                double valorTransferencia = Convert.ToDouble(Console.ReadLine());

                if (valorTransferencia <= 0)
                {
                    Console.WriteLine("ERRO: Valor De Transefêrencia Invalido");
                }
                else if ((valorTransferencia > contaJoao) || (valorTransferencia > contaMaria))
                {
                    Console.WriteLine("ERRO: Saldo insuficiente para realizar a transferência.");
                }
                else
                {

                    if (beneficiario.ToLower() == nomeJoao)
                    {
                        contaJoao += valorTransferencia;
                        contaMaria -= valorTransferencia;
                    }
                    else
                    {
                        contaMaria += valorTransferencia;
                        contaJoao -= valorTransferencia;
                    }

                    Console.WriteLine($"Transferência de {valorTransferencia:C2} para {beneficiario} realizada com sucesso!");
                    Console.WriteLine($"Saldo atual de João: {contaJoao:C2}");
                    Console.WriteLine($"Saldo atual de Maria: {contaMaria:C2}");
                }
            }
            else
            {
                Console.WriteLine("ERRO: Beneficiario Não Encontrado ");
            }
        }
        else
        {
            Console.WriteLine("ERRO: Remetente não encontrado ");
        }
    }

    static void Saldo()
    {
        Console.Write("Informe o Nome do Usuario:");
        string usuario = Console.ReadLine().ToLower();

        if (usuario == nomeJoao)
        {
            Console.WriteLine($"Saldo Atual: {contaJoao:C2}R$");
        }
        else if (usuario == nomeMaria)
        {
            Console.WriteLine($"Saldo Atual: {contaMaria:C2}R$");
        }
        else
        {
            Console.WriteLine("ERRO: Usuario Não Encontrado");
        }
    }

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Bem-vindo ao sistema de transferência PIX!");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Realizar uma transferência");
            Console.WriteLine("2. Verificar Saldo");
            Console.WriteLine("3. Sair");

            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Transferencia();
                    break;
                case 2:
                    Saldo();
                    break;
            }
            if (escolha == 3)
            {
                Console.WriteLine("Obrigado por usar o sistema de transferência PIX. Adeus!");
                break;
            }
        }
    }
}