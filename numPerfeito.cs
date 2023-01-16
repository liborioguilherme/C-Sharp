using System;

public class Test
{
	public static void Main()
	{
		int i,soma=0,n;
  
  Console.WriteLine("Digite um número para saber se ele é perfeito!");
 
    n = int.Parse(Console.ReadLine());
 
   for(i=1;i<5;i++){
 
   if(n % i == 0){
    soma+=i;
   
 }
    }
   
 if(soma==n){
   
  Console.WriteLine("O número " + n + " é perfeito!");
  
  }else{
  
   Console.WriteLine("não é perfeito");
  
  }
    
    
  
	}
}
