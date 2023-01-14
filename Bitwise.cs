using System;

class Program {
    static void Main(string[] args) {
      
    int num1,num2;
            // esse operador Bitwise dobra o valor
            Console.WriteLine("digite um valor e ele sera dobrado");
                num1 = int.Parse(Console.ReadLine());
            num1 = num1<<1;
       Console.WriteLine(num1);
            // esse operador Bitwise diminui pela metade o valor
             Console.WriteLine("digite um valor e ele sera diminuido pela metade");
             num2 = int.Parse(Console.ReadLine());
             num2 = num2>>1;
       
              Console.WriteLine(num2);
        
             





              
      }
}