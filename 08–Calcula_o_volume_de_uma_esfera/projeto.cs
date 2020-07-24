using System;

/*Calcular o volume de uma esfera. Mostra como declarar variáveis e utilizar console e o método pow*/
class projeto{

    static void Main(){
        double pi,raio,volume;

        pi=3.14;

        Console.Write("Insira o raio: ");
        raio = double.Parse (Console.ReadLine());

        volume=((4*pi*Math.Pow(raio,3)/3));

        Console.WriteLine("O volume da esfera é: {0} metros cúbicos",volume);
        Console.WriteLine();
       

    }
}