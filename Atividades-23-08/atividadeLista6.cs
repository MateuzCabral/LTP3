// 06 Escreva um programa em C# que compute a soma de dois valores numéricos inseridos pelo usuário. Se os valores forem iguais, retornar o triplo da soma entre ambos.
using System;
namespace exercicios{

	public class exercicio6{
        public static void Main(string[] args){
            Console.WriteLine("Informe o primeiro numero: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Informe o segundo numero: ");
            int numberTwo= Convert.ToInt32(Console.ReadLine());
            
            if(numberOne == numberTwo){
                int triple = (numberOne+numberTwo) * 3;
                Console.WriteLine(triple);
            }else{
                Console.WriteLine(numberOne+numberTwo);
		    }	
        }
    }
}