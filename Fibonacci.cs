using System;

public class Test
{
	public static void Main()
	{
		int i,n,t1=0,t2=1,proxTermo;

    Console.WriteLine("Digite a quantidade de termos");
 
  n = int.Parse(Console.ReadLine());
  
   for(i=1;i<=n;i++){
 
   Console.Write(t1 + " ");
   
 proxTermo = t1+t2;
   
   t1=t2;
  
  t2=proxTermo;
}
	}
}
