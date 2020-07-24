using System;
/*Converter a temperatura em graus Fahrenheit para graus Celsius. Utiliza console de entrada e saída de dados.*/
class projeto{

    static void Main(){

        double f, c;

        Console.Write("Insira o valor em Fahrenheit: ");
        f = double.Parse(Console.ReadLine());

        c = ((f - 32)* 5/9);

       Console.WriteLine("\tA temperatura de {0} graus Fahrenheit equivale a: {1} graus Celsius", f, c);
    }
}



