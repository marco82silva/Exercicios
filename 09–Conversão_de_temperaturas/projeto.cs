using System;
/*Converter a temperatura em graus Fahrenheit para graus Celsius. Utiliza console de entrada e saída de dados.*/
class projeto{

    static void Main(){

        double F, C;

        Console.Write("Insira o valor em Celsius: ");
        C = double.Parse(Console.ReadLine());

        F = (((9 * C)+ 160)/5);

       Console.WriteLine("\tA temperatura de {0} graus Fahrenheit equivale a: {1} graus Celsius", C, F);
    }
}



