using System;

public class Test
{
	public static void Main()
	{
		
 int n,i,fat=1;
 n = int.Parse(Console.ReadLine());
 
  for(i=n;i>1;i--){

  fat=fat*i;
}

Console.WriteLine("o fatorial de " + n + " e " + fat);

	}
}
