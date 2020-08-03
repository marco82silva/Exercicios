using System;
/*Calcular o quadrado de um número qualquer. Simples utilização de entrada e saída
de dados via console e o método Math.Pow*/
class projeto{
    static void Main(){

        double N1,X;

        Console.Write("Informe um numero: ");
        N1=double.Parse(Console.ReadLine());
        Console.Write("Informe o numero que sera levado ao quadrado: ");
        X=double.Parse(Console.ReadLine());

        X=Math.Pow(N1,2);

        Console.Write("O valor do numero {0} elevado a potencia 2 é: {1}",N1,X);
    }
}