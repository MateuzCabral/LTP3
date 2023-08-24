using System;

namespace exercicios{

public class Atividade1{
    public static void Main(string[] args){
	    Console.WriteLine("Informe o Ano do seu Nascimento:");
		int year = Convert.ToInt32(Console.ReadLine());	
		
		int currentYear= DateTime.Now.Year;
		
		int age = currentYear - year;
		
		Console.WriteLine("Vocẽ tem "+ age +"Anos");
        }
    }
}