using System;
class projeto{

    static void Main(){
 double N1, // Primeiro número a ser fornecido pelo usuário
N2, // Segundo número a ser fornecido pelo usuário
T; // Variável auxiliar para efetuar a troca dos números
// Solicita e lê os números a serem fornecidos pelo usuário
Console.Write("Por favor entre com o 1º número X: ");
N1 = Double.Parse(Console.ReadLine());
Console.Write("Por favor entre com o 2º número Y: ");
N2 = Double.Parse(Console.ReadLine());
// Efetua a troca dos valores fornecidos
T = N1;
N1 = N2;
N2 = T;
// Exibe os números fornecidos pelo usuário de forma invertida
Console.WriteLine("O número fornecido X = {0}, agora é: {1}",N2,N1);
Console.WriteLine("O número fornecido Y = {0}, agora é: {1}",N1,N2);       
    }
}