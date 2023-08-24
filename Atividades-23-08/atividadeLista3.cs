// 03 - Elabore um programa em C# que peça ao usuário sua data de nascimento e calcule sua idade. Em seguida, exiba a idade em anos.

using System;
namespace exercicios{
	
	public class exercicio3{
    	public static void Main(string[] args){
		
			Console.WriteLine("Informe o Ano do seu Nascimento:");
			int year = Convert.ToInt32(Console.ReadLine());	
			
			int currentYear= DateTime.Now.Year;
			
			int age = currentYear - year;
			
			Console.WriteLine("Vocẽ tem "+ age +"Anos");
		}
	}
}

