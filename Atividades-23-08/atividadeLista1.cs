// Lista de Exercícios em C# no 1.0
// 01 -  Escreva um programa em C# que peça ao usuário que digite um número inteiro e então imprima o número digitado pelo usuário.

using System;
namespace exercicios{

    public class exercicio1{
        public static void Main(string[] args){

    		Console.WriteLine("Digite Um Numero:");
		    int numero = Int32.Parse(Console.ReadLine());
		    Console.WriteLine("O Numero Informado é: " + numero);
        }
    }
}