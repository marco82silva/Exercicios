using System;
/*Calcular o volume de uma lata de óleo. Demonstra de forma simples como declarar variáveis, expressões e apresentar 
os dados via console*/
class projeto{

    static void Main(){
        double volume,raio,altura;

        Console.Write("Insira o raio lata de óleo: ");
        raio=double.Parse(Console.ReadLine());
        Console.Write("Insira a Altura da lata de óleo: ");
        altura=double.Parse(Console.ReadLine());

        volume = ((3.14159*raio)-(2*altura));
        
        Console.Write ("\tO volume da lata de óleo é: {0}",volume);
        Console.ReadLine();
        
    }
}