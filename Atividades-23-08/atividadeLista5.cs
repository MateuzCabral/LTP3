// 05 - Construa uma aplicação em C# em que o usuário insere um númnero e a aplicação retorna se o número é par ou ímpar.
using System;
namespace exercicios{

	public class exercicio5{
        public static void Main(string[] args){

            Console.WriteLine("Informe Um Numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            
            if (numero % 2 == 0){
                Console.WriteLine("O Numero é par");
            }else{
                Console.WriteLine("O Numero é Impar");
            }
        }
    }
}

