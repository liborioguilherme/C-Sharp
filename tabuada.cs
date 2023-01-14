using System;

class Program {
    static void Main(string[] args) {
      
   int num,i=1,res;
            Console.WriteLine("digite um numero para saber a tabuada");
      num = int.Parse(Console.ReadLine());
      while(i<=10){
         res = num*i;
        Console.WriteLine(num + " x " + i + " = " +res);
        i++;
      }
      
        
             





              
      }
}