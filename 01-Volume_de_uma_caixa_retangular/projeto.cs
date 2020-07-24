using System;
/*
Calcular o volume de uma caixa retangular mostra de forma simples como declarar
variáveis e manipular dados de entrada e saída via console
*/

class projeto{

    static void Main(){

     double altura, largura, comprimento,volume;

    Console.Write("Por favor entre com a medida do comprimento da caixa em metros: ");
    comprimento = double.Parse(Console.ReadLine());
    Console.Write("Por favor entre com a media da largura da caixa em metros: ");
    largura = double.Parse(Console.ReadLine());
    Console.Write("Por favor entre com a medida do altura da caixa em metros: ");
    altura = double.Parse(Console.ReadLine());

    volume=comprimento*largura*altura;

    Console.WriteLine("O volume da caixa retangular com {0} metros de comprimento, {1} metros de largura e {2} metros de altura é de: {3} metros cúbicos", comprimento, largura, altura, volume);
    
    }
}