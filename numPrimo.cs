using System;

public class Test
{
	public static void Main()
	{
		int i=0,n;

Console.WriteLine("Digite um número para saber se é primo ou nao:");

 n = int.Parse(Console.ReadLine());

if(n<=1){

Console.WriteLine("não é primo");

}else{

for(i=2;i<n;i++){

  if(n%i==0){

  Console.WriteLine("não é primo");
}

}
}
if(i==n){
 
Console.WriteLine("e primo");
}
	}
}
