// 04 - Desenvolva uma aplicação em linguagem C# que solicite ao usuário um número e retorne a tabuada desse número de 0 a 10.
using System;
namespace exercicios{

	public class exercicio4{
        public static void Main(string[] args){

		    Console.WriteLine("Informe Um Numero:");
		    int numero = Convert.ToInt32(Console.ReadLine());
		    for(int i = 0;i<=10;i++){
		    Console.WriteLine(numero +" X "+ i + " = "+ numero*i);
            
            }
        }
    }
}

