using System;
/*Calcular o volume de um Cilindro. Mostra de forma simples a declaração de variáveis e entrada e saída de dados*/
class projeto{

    static void Main(){
        
        double arebase, volume, areatotal, altura, raio, calculo, pi;

        pi=3.14;

        Console.Write("Insira o Raio do Cilindro: ");
        raio=double.Parse(Console.ReadLine());

        Console.Write("Insira a Area Altura do Cilindro: ");
        altura=double.Parse(Console.ReadLine());

        arebase=(pi*raio*raio);
        volume=(arebase*altura);
    
        Console.WriteLine("O volume do cilindro é: {0}", volume);




    }
}