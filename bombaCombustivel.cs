using System;

public class Test
{
	public static void Main()
	{
		double preco=0,gasolina = 5,etanol = 4,gnv = 3,res=0;
		int op=0;
		Console.WriteLine("digite um numero para abastecer \n 1 - gasolina \n 2 - etanol \n 3 - gnv");
		op = int.Parse(Console.ReadLine());
		  if(op==1){
		  Console.WriteLine("o valor da gasolina e R$" + gasolina);
		  Console.WriteLine("digite o valor para abastecer");
		  preco = int.Parse(Console.ReadLine());
		  res = (preco/gasolina);
         Console.WriteLine("voce abasteceu " + res + " litros de gasolina");
		  }else if(op==2){
		   Console.WriteLine("o valor do etanol e R$" + etanol);
		  Console.WriteLine("digite o valor para abastecer");
		  preco = int.Parse(Console.ReadLine());
		  res = preco/etanol;
         Console.WriteLine("voce abasteceu " + res + " litros de etanol");
		  }else if(op==3){
		   Console.Write("o valor do gnv e R$" + gnv);
		  Console.WriteLine("digite o valor para abastecer");
		  preco = int.Parse(Console.ReadLine());
		  res = preco/etanol;
         Console.WriteLine("voce abasteceu " + res + " litros de gnv");
		  }
	}
}
