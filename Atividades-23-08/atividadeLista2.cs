// 02 - Escreva um código em C# que Solicite ao usuário que escreva seu nome e depois solicite o seu sobrenome. Ao final, imprima no console o nome e o sobrenome juntos em uma mesma linha.

using System;
namespace exercicios{

	public class exercicio2{
    	public static void Main(string[] args){	
			Console.WriteLine("Informe o Seu Nome:");
			string name = Console.ReadLine();
		
			Console.WriteLine("Informe o Seu Sobrenome:");
			string lastName = Console.ReadLine();
		
			Console.WriteLine("Seu Nome é "+ name +" "+ lastName);
	
    	}
	}
}