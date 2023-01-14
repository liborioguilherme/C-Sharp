using System;

public class Test
{
	public static void Main()
	{
		int num;
		Console.WriteLine("digite um numero para saber se ele e par,impar,positivo ou negativo");
	   num = int.Parse(Console.ReadLine());
	   if(num > 0){
	   Console.WriteLine("o numero " + num + " e positivo");
	   }else{
	   Console.WriteLine("o numero " + num + " e negativo");
	   }
	   if(num %2 == 0){
	   Console.WriteLine("o numero " + num + " e par");
	   }else{
	   Console.WriteLine("o numero " + num + " e impar");
	   }
	
	
	}
}
