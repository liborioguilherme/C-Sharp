using System;

public class Test
{
	public static void Main()
	{
		int calc,ano1,ano2,dias,minutos,segundos,mes;
        Console.WriteLine("digite o ano exemplo: 2023");
        ano1 = int.Parse(Console.ReadLine());
         Console.WriteLine("digite seu ano de nascimento");
         ano2 = int.Parse(Console.ReadLine());
          calc = ano1 - ano2;
		mes = ano1*12;
          dias = calc*365;
    minutos = dias*60;
    segundos = minutos *60;
          
          Console.WriteLine("Você fez esse ano " + calc + " anos");
		 Console.WriteLine("vove ja viveu " + mes + " meses");
      Console.WriteLine("Você já viveu "+ dias + " dias");  
     Console.WriteLine("Você já viveu "+ minutos + " minutos");
     Console.WriteLine("Você já viveu " + segundos + " segundos");
         
        
	}
}
